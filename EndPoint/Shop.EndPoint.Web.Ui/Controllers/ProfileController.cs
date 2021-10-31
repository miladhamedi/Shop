using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using Shop.Core.Service.Services.Comments;
using Shop.Core.Service.Services.Invoices;
using Shop.Core.Service.Services.Messages;
using Shop.Core.Service.Services.ShopingCart;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserRole;
using Shop.Core.Service.ServiceSender;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Controllers
{
    [Authorize(Roles = "User")]
    public class ProfileController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserRoleService userRoleService;
        private readonly IMessageService messageService;
        private readonly IMapper mapper;
        private readonly ICommentService commentService;
        private readonly IinvoiceService iinvoiceService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<ProfileController> loggerFactory;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IShopingCartService shopingCartService;

        public ProfileController(IUserService userService, IUserRoleService
            userRoleService, IMessageService messageService, IMapper mapper,
            ICommentService commentService, IinvoiceService iinvoiceService,
            UserManager<ApplicationUser> userManager,
            ILogger<ProfileController> loggerFactory,
            SignInManager<ApplicationUser> signInManager, IShopingCartService shopingCartService)
        {
            this.userService = userService;
            this.userRoleService = userRoleService;
            this.messageService = messageService;
            this.mapper = mapper;
            this.commentService = commentService;
            this.iinvoiceService = iinvoiceService;
            this.userManager = userManager;
            this.loggerFactory = loggerFactory;
            this.signInManager = signInManager;
            this.shopingCartService = shopingCartService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddInformationUser(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.Name;

                var AppUser = userService.GetByUserName(user);
                AppUser.City = model.City;
                AppUser.Province = model.Province;
                AppUser.Address = model.Address;
                AppUser.PostalCode = model.PostalCode;
                AppUser.IrCode = model.IrCode;
                AppUser.ActiveCode = CodeGenerators.ActiveCode();
                userService.UpdatedUser(AppUser);

                TempData["Status"] = true;
                TempData["Message"] = "اطلاعات کاربر با موفقیت ثبت شد";
                return RedirectToAction("Index");
            }
            TempData["Status"] = false;
            TempData["Message"] = "اطلاعات کاربر با موفقیت ثبت شد";
            return RedirectToAction("Index", model);

        }




        public IActionResult ConfirmPhone(PhoneNumberViewModel model, string returnurl = null)
        {
            if (ModelState.IsValid)
            {
                var appuser = User.Identity.Name;
                var user = userService.GetByUserName(appuser);
                if (user.PhoneNumber == model.PhoneNumber)
                {
                
                    TempData["Status"] = false;
                    TempData["Message"] = "شماره همراه از قبل وجود دارد";
                    return RedirectToAction("ChangPhoneNumber");

                }
                SmsSender sender = new SmsSender();
                sender.SMS(model.PhoneNumber, "ب فروشگاه اینترنتی خوش آمدید" + Environment.NewLine + "کد فعالسازی" + user.ActiveCode);
                ViewBag.PhoneNu = model.PhoneNumber;
                ViewBag.url = returnurl;
                ViewBag.Status = true;
                ViewBag.Message = "کد فعالسازی ب شماره همراه ارسال شد";
                return View();
            }
            if (Url.IsLocalUrl(returnurl))
            {
                TempData["Status"] = false;
                TempData["Message"] = "لطفا شماره همراه را وارد نمائید";
                return RedirectToAction("ChangPhoneNumber");

            }
            TempData["Status"] = false;
            TempData["Message"] = "شماره همراه را وارد کنید";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmPhone(ComfirmPhoneViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.Name;
                var AppUser = userService.GetByUserName(user);
                if (AppUser.ActiveCode == model.ActiveCode)
                {
                    AppUser.PhoneNumberConfirmed = true;
                    AppUser.PhoneNumber = model.PhoneNumber;
                    userService.UpdatedUser(AppUser);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.Status = false;
                    ViewBag.Message = "کد فعالسازی اشتباه وارد شده است";
                    return View();
                }
            }
            ViewBag.Status = false;
            ViewBag.Message = "کد فعالسازی را وارد کنید";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInformationUser(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = User.Identity.Name;
                var AppUser = userService.GetByUserName(user);
                AppUser.City = model.City;
                AppUser.Province = model.Province;
                AppUser.Address = model.Address;
                AppUser.IrCode = model.IrCode;
                AppUser.PostalCode = model.PostalCode;
                userService.UpdatedUser(AppUser);
                TempData["Status"] = true;
                TempData["Message"] = "ویرایش کاربر باموفقیت انجام شد";
                return RedirectToAction("Index");

            }
            TempData["Status"] = false;
            TempData["Message"] = "ویرایش کاربر با موفقیت انجام نشد";
            return RedirectToAction("Index", model);


        }

        public IActionResult ChangPhoneNumber()
        {
            var user = User.Identity.Name;
            var AppUser = userService.GetByUserName(user);
            ViewBag.PhoneNumber = AppUser.PhoneNumber;
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];
            return View();
        }


        public IActionResult MessageSend()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MessageSend(AddMessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var AdminRole = userRoleService.GetByAdminRole();
                var SenderUser = userService.GetByUserName(model.UserNameSend);
                var UserModel = new MessageDto();

                UserModel.UserIdRecive = AdminRole.UserId;
                UserModel.UserIdSend = SenderUser.Id;
                UserModel.Text = model.Text;
                UserModel.Date = DateTime.Now;
                UserModel.Confirm = false;

                TempData["Message"] = "OK";
                messageService.AddMessage(UserModel);

                return RedirectToAction("MessageSend");
            }


            TempData["Message"] = "NotOk";
            return RedirectToAction("MessageSend");
        }

        public IActionResult MessageSendUserAll(int page = 1)
        {
            var user = User.Identity.Name;
            var AppUser = userService.GetByUserName(user);
            var UserMessage = messageService.GetUserMessageAll(AppUser.Id, page);
            ShopActionResult<List<MessageViewModel>> shopActionResults = new ShopActionResult<List<MessageViewModel>>();
            List<MessageViewModel> messageViewModels = new List<MessageViewModel>();
            foreach (var item in UserMessage.Data)
            {
                var messageAll = mapper.Map<MessageViewModel>(item);
                messageViewModels.Add(messageAll);
            }
            shopActionResults.Data = messageViewModels;
            shopActionResults.Page = UserMessage.Page;
            shopActionResults.Pages = UserMessage.Pages;
            shopActionResults.ItemCount = UserMessage.ItemCount;
            shopActionResults.Counts = UserMessage.Counts;

            return View(shopActionResults);
        }

        public IActionResult MessageReply(int page = 1)
        {
            var user = User.Identity.Name;
            var AppUser = userService.GetByUserName(user);
            var UserMessage = messageService.GetAdminMessageRecive(AppUser.Id, page);
            ShopActionResult<List<MessageViewModel>> shopActionResults = new ShopActionResult<List<MessageViewModel>>();
            List<MessageViewModel> messageViewModels = new List<MessageViewModel>();
            foreach (var item in UserMessage.Data)
            {
                var messageAll = mapper.Map<MessageViewModel>(item);
                messageViewModels.Add(messageAll);
            }
            shopActionResults.Data = messageViewModels;
            shopActionResults.Page = UserMessage.Page;
            shopActionResults.Pages = UserMessage.Pages;
            shopActionResults.ItemCount = UserMessage.ItemCount;
            shopActionResults.Counts = UserMessage.Counts;

            return View(shopActionResults);
        }


        public IActionResult ListComment(int page = 1)
        {
            ShopActionResult<List<CommentViewModel>> shopActionResult = new ShopActionResult<List<CommentViewModel>>();
            var user = User.Identity.Name;
            var listComment = commentService.AllCommentProfile(user, page);
            shopActionResult.Page = listComment.Page;
            shopActionResult.Pages = listComment.Pages;
            List<CommentViewModel> commentViewModels = new List<CommentViewModel>();
            foreach (var item in listComment.Data)
            {
                CommentViewModel commentViewModel = new CommentViewModel();
                commentViewModel.UserId = item.UserId;
                commentViewModel.ProductId = item.ProductId;
                commentViewModel.CommentId = item.CommentId;
                commentViewModel.Date = item.Date;
                commentViewModel.Confirm = item.Confirm;
                commentViewModel.ProductName = item.ProductName;
                commentViewModel.Email = item.Email;

                commentViewModels.Add(commentViewModel);

            }

            shopActionResult.Data = commentViewModels;
            return View(shopActionResult);
        }


        public IActionResult OrderList(int page = 1)
        {
            ShopActionResult<List<InvoiceViewModel>> shopActionResult = new ShopActionResult<List<InvoiceViewModel>>();
            var user = User.Identity.Name;
            var listOrder = iinvoiceService.GetOrderProfile(user, page);
            shopActionResult.Page = page;
            shopActionResult.Pages = listOrder.Pages;
            List<InvoiceViewModel> invoiceViewModels = new List<InvoiceViewModel>();
            foreach (var item in listOrder.Data)
            {
                var ListOrder = mapper.Map<InvoiceViewModel>(item);
                invoiceViewModels.Add(ListOrder);
            }
            shopActionResult.Data = invoiceViewModels;
            return View(shopActionResult);
        }

        public IActionResult InvoiceDetails(int invoicenumber)
        {

            List<ShopingCartViewModel> shopingCartViewModels = new List<ShopingCartViewModel>();
            var ShopingInvoice = shopingCartService.GetByInvoiceId(invoicenumber);
            foreach (var item in ShopingInvoice)
            {
                var shop = mapper.Map<ShopingCartViewModel>(item);
                shopingCartViewModels.Add(shop);
            }
            return View(shopingCartViewModels);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            ViewBag.OK = TempData["OK"];

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ResetPWProfile model)
        {

            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    //loggerFactory.LogError(3, "نغییر پسورد با موفقیت انجام شد");

                    TempData["OK"] = "OK";
                    return RedirectToAction("ChangePassword");
                }

            }

            return View(model);
        }

        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return userManager.GetUserAsync(User);

        }




    }
}

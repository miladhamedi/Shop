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
            SignInManager<ApplicationUser> signInManager,IShopingCartService shopingCartService)
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddInformationUser(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {

                var AppUser = userService.GetByUserName(userViewModel.UserName);
                AppUser.City = userViewModel.City;
                AppUser.Province = userViewModel.Province;
                AppUser.Address = userViewModel.Address;
                AppUser.PostalCode = userViewModel.PostalCode;
                AppUser.IrCode = userViewModel.IrCode;
                userService.UpdatedUser(AppUser);
                TempData["Message"] = "Add";
                return RedirectToAction("Index");
            }
            TempData["Message"] = "NotAdd";
            return View(userViewModel);

        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInformationUser(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = userService.GetByUserName(userViewModel.UserName);
                user.City = userViewModel.City;
                user.Province = userViewModel.Province;
                user.Address = userViewModel.Address;
                user.IrCode = userViewModel.IrCode;
                user.PostalCode = userViewModel.PostalCode;
                userService.UpdatedUser(user);
                TempData["Message"] = "Edit";
                return View("Index");
            }
            TempData["Message"] = "NotEdit";
            return View(userViewModel);

        }




        public IActionResult MessageSend()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MessageSend(MessageViewModel messageViewModel)
        {
            if (ModelState.IsValid)
            {
                var AdminRole = userRoleService.GetByAdminRole();
                var SenderUser = userService.GetByUserName(messageViewModel.UserNameSend);
                var UserModel = new MessageDto();

                UserModel.UserIdRecive = AdminRole.UserId;
                UserModel.UserIdSend = SenderUser.Id;
                UserModel.Text = messageViewModel.Text;
                UserModel.Date = DateTime.Now;
                UserModel.Confirm = false;

                TempData["Message"] = "OK";
                messageService.AddMessage(UserModel);

                return RedirectToAction("MessageSend");
            }



            return View(messageViewModel);
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

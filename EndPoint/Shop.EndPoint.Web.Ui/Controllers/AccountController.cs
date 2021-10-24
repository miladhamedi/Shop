using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserPages;
using Shop.Core.Service.Services.UserRole;
using Shop.Core.Service.ServiceSender;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IEmailSender emailSender;
        private readonly ILogger<AccountController> loggerFactory;
        private readonly IUserRoleService userRoleService;
        private readonly IUserService userService;
        private readonly IUserPageService userPageService;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ILogger<AccountController> loggerFactory,
            IUserRoleService userRoleService,
            IUserService userService,IUserPageService userPageService)
        {

            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
            this.loggerFactory = loggerFactory;
            this.userRoleService = userRoleService;
            this.userService = userService;
            this.userPageService = userPageService;
        }

        public IActionResult LoginAdmin()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAdmin(LoginViewModel model, string returnUrl)
        {
          
            if (ModelState.IsValid)
            {
              
                var userpermission = userPageService.GetPermissionUser(model.Email, "Index","Manage");

                if (userpermission.Count > 0)
                {
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        //loggerFactory.LogInformation(1, "کاربر وارد شد.");
                        return LocalRedirect(returnUrl);
                    }
                }
                else
                {
                    TempData["Message"] = "کاربر گرامی ب صفحه مدیریت دسترسی ندارید";
                    TempData["Status"] = "Notok";
                    return RedirectToAction("LoginAdmin");
                }

            }

            TempData["Message"] = "کاربر گرامی ورود ناموفق بود";
            TempData["Status"] = "Notok";
            return RedirectToAction("LoginAdmin");


        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Profile");
            
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];

            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = userService.GetByUserName(model.Email);
            if (user == null)
            {
                TempData["Message"] = "اطلاعات با دقت پر شود";
                TempData["Status"] = "NotOk";
                return RedirectToAction("Login");
            }
            if (user.Access == true)
            {
                if (User.Identity.IsAuthenticated)
                    return RedirectToAction("Index", "Profile");

                if (ModelState.IsValid)
                {
                    var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                       
                        //loggerFactory.LogError(1, "کاربر وارد شد");
                        return RedirectToAction("Index", "Profile");



                    }
                    else
                    {
                        TempData["Message"] = "ورود ناموفق مجدد تلاش کنید";
                        TempData["Status"] = "NotOk";
                        return RedirectToAction("Login");
                    }


                }

                TempData["Message"] = "اطلاعات با دقت پر شود";
                TempData["Status"] = "NotOk";
                return RedirectToAction("Login");

            }
            else
            {
                TempData["Message"] = "دسترسی شما از طرف مدیریت سایت محدود شده است";
                TempData["Status"] = "NotOk";
                return RedirectToAction("Login");
            }


          


        }



        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            //loggerFactory.LogError(4, "کاربر خارج شد");
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Profile");
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Profile");

            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { NameFamily = model.NameFamily, Email = model.Email, UserName = model.Email, PhoneNumber = model.PhoneNumber, Date = DateTime.Now, Access = true };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {

                    userRoleService.AddUserRole(user.Id);

                    var Code = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, code = Code }, protocol: HttpContext.Request.Scheme);
                    await emailSender.EmailSenderAsync(model.Email, "لینک فعالسازی اکانت کاربری", $"لطفا روی لینک فعال سازی کلیک کنید<a href='{callbackUrl}'> اینجا</a>");

                    TempData["Status"] = "Ok";
                    TempData["Message"] = "فقط در صورت فعال سازی امکان ورود خواهید داشت " +
                        " مشخصات شما با موفقیت ثبت شدلینک فعال سازی ب ایمیل شماارسال شد";


                    return RedirectToAction("Register");

                }
                else
                {
                    TempData["Status"] = "Notok";
                    TempData["Message"] = "ثبت نام نا موفق مجدد تلاش کنید";

                    return RedirectToAction("Register", model);

                }
            }
            return View(model);
        }





        public async Task<IActionResult> ConfirmEmail(Guid userId, string code)
        {
          
            var UserId = Convert.ToString(userId);

            var user = await userManager.FindByIdAsync(UserId);
            if (user == null)
            {
                return View("Error", "Home");
            }
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result == null)
            {
                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction("Register");

        }



        public IActionResult ForgotPassword()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user == null || !await userManager.IsEmailConfirmedAsync(user))
                {

                    TempData["Message"] = "Failure";
                    return RedirectToAction("ForgotPassword");
                }


                var Code = await userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action(nameof(ResetPassword), "Account", new { userId = user.Id, code = Code }, protocol: HttpContext.Request.Scheme);
                await emailSender.EmailSenderAsync(model.Email, "ریست پسورد",
                   $"لطفا برای ریست پسورد کلیک کنید: <a href='{callbackUrl}'>link</a>");

                TempData["Message"] = "Ok";
                return RedirectToAction("ForgotPassword");
            }


            return View(model);
        }


        public IActionResult ResetPassword(Guid userId, string code)
        {

            if (code == null || userId == null)
            {
                return View("Home", "Error");
            }
            else
            {
                ViewBag.Message = TempData["Message"];
                ViewBag.code = code;
                ViewBag.userid = userId;
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userEmail = userService.GetEmailUser(model.UserId);
                var user = await userManager.FindByEmailAsync(userEmail);
                if (user == null)
                {
                    TempData["Message"] = "Failure";
                    return RedirectToAction("ResetPassword");
                }
                var result = await userManager.ResetPasswordAsync(user, model.Code, model.Password);
                if (result.Succeeded)
                {
                    TempData["Message"] = "پسورد شما ریست شد لطفا مجدد وارد شوید";
                    TempData["Status"] = "Ok";
                    return RedirectToAction("Login");
                }
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginComment(string email, string password, bool RememberMe, string returnurl)
        {

            var result = await signInManager.PasswordSignInAsync(email, password, RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                //loggerFactory.LogError(1, "کاربر وارد شد");
                return LocalRedirect(returnurl);
            }


            TempData["Message"] = "ورود نا موفق بود ثبت نام کنید";
            TempData["Status"] = "NotOk";

            return LocalRedirect(returnurl);

        }


    }
}

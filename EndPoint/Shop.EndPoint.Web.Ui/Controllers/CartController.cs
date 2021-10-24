using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Colors;
using Shop.Core.Service.Services.Invoices;
using Shop.Core.Service.Services.Products;
using Shop.Core.Service.Services.Setting;
using Shop.Core.Service.Services.ShopingCart;
using Shop.Core.Service.Services.TechnicalDetails;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.Weights;
using Shop.Core.Service.ServiceSender;
using Shop.EndPoint.Web.Ui.ViewModel;
using Shop.Infrastructure.Data.Sql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Controllers
{
    [Authorize(Roles = "User")]
    public class CartController : Controller
    {
        private readonly IProductService productService;
        private readonly IUserService userService;
        private readonly IColorService colorService;
        private readonly ITechnicalDetailService technicalDetailService;
        private readonly IinvoiceRepository iinvoiceRepository;
        private readonly IShopingCartService shopingCartService;
        private readonly IMapper mapper;
        private readonly IWeightService weightService;
        private readonly IinvoiceService iinvoiceService;
        private readonly ISettingService settingService;
        private readonly IEmailSender emailSender;
       

        public CartController(IProductService productService,
            IUserService userService, IColorService colorService,
            ITechnicalDetailService technicalDetailService,
            IShopingCartService shopingCartService,
            IMapper mapper, IWeightService weightService,
            IinvoiceService iinvoiceService, ISettingService settingService,
            IEmailSender emailSender, IinvoiceRepository iinvoiceRepository)

        {
            this.productService = productService;
            this.userService = userService;
            this.colorService = colorService;
            this.technicalDetailService = technicalDetailService;
            this.shopingCartService = shopingCartService;
            this.mapper = mapper;
            this.weightService = weightService;
            this.iinvoiceService = iinvoiceService;
            this.settingService = settingService;
            this.emailSender = emailSender;
            this.iinvoiceRepository = iinvoiceRepository;
        }


        public IActionResult ListCart()
        {
            var AppUser = User.Identity.Name;
            var user = userService.GetByUserName(AppUser);
            var Shoping = shopingCartService.GetAllUserById(user.Id);

            if (user != null && Shoping != null)
            {
                
                List<decimal> listsum = new List<decimal>();
                foreach (var item in Shoping)
                {
                    var Price = Convert.ToDouble(item.Price) * item.Count;
                    var PriceSum = (Price * 0.09) + Price;
                    var pricedeci = Convert.ToDecimal(PriceSum);
                    listsum.Add(pricedeci);

                }

                List<decimal> listDiscount = new List<decimal>();
                foreach (var item in Shoping)
                {
                   
                    var product = productService.GetByIdPro(item.ProductId);
                    var percent = product.DiscuntPercent == 0 ? 0 : product.DiscuntPercent;
                    var percentDiscount = percent;
                    var price = item.Price;
                    var pricepercent = price * percentDiscount;
                    var Discount = (pricepercent / 100);
                    var pricepercentcount = Discount * item.Count;
                    listDiscount.Add(pricepercentcount);
                }
                ViewBag.Discount = listDiscount.Sum();
                ViewBag.sumprice = listsum.Sum() - ViewBag.Discount;

                List<ShopingCartViewModel> shopingCartViewModels = new List<ShopingCartViewModel>();

                foreach (var item in Shoping)
                {
                    var shopping = mapper.Map<ShopingCartViewModel>(item);
                    shopingCartViewModels.Add(shopping);
                }

                return View(shopingCartViewModels);
            }

            return RedirectToAction("Index", "Home");
        }



        [HttpPost]
        public IActionResult AddCart(int productid, int colorid)
        {
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");

            var AppUser = User.Identity.Name;
            var user = userService.GetByUserName(AppUser);
            var Product = productService.GetByIdPro(productid);

            if (user != null && Product != null)
            {
                var technical = technicalDetailService.GetByProductId(Product.ProductId);
                var color = colorService.GetByColorId(colorid);

                if (technical == null || color == null)
                {
                    TempData["Message"] = "رنگ و گارانتی محصول را انتخاب کنید";
                    TempData["Status"] = "NotOk";

                    return RedirectToAction("ProductDetails", "Product", new { productid = productid });
                }

                var shopingCart = shopingCartService.GetCart(user.Id, Product.ProductId);

                if (shopingCart == null)
                {
                    ShopingCartDto shopingCartDto = new ShopingCartDto();

                    var taxPrice =Convert.ToDouble(Product.Price) * 0.09;
                    shopingCartDto.Tax = Convert.ToDecimal(taxPrice);
                    shopingCartDto.Price = Product.Price;
                    decimal Amount = 0;
                    shopingCartDto.ProductId = Product.ProductId;
                    shopingCartDto.UserId = user.Id;
                    shopingCartDto.Warranty = technical.Warranty;
                    shopingCartDto.AmountSent = Amount;
                    shopingCartDto.ProductCode = Product.CodeProduct;
                    shopingCartDto.Date = DateTime.Now;
                    shopingCartDto.InvoiceNumber = 0;
                    shopingCartDto.Count = 1;
                    shopingCartDto.Status = false;
                    shopingCartService.AddCart(shopingCartDto);
                    TempData["Message"] = "محصول ب سبد خرید اضافه شد";
                    TempData["Status"] = "Ok";

                    return RedirectToAction("ProductDetails", "Product", new { productid = Product.ProductId });

                }
                else
                {

                    shopingCart.Count += 1;
                    shopingCartService.UpdateCart(shopingCart);

                    TempData["Message"] = "سبد خرید بروز شد";
                    TempData["Status"] = "Ok";

                    return RedirectToAction("ProductDetails", "Product", new { productid = Product.ProductId });
                }



            }

            TempData["Message"] = "اضافه شدن ب سبد خرید ناموفق بود";
            TempData["Status"] = "NotOk";

            return RedirectToAction("ProductDetails", "Product", new { productid = productid });
        }

        public IActionResult RemoveCart(int cartid)
        {
            var Appuser = User.Identity.Name;
            var user = userService.GetByUserName(Appuser);
            var shopping = shopingCartService.GetShopingCart(cartid, user.Id);
            if (shopping.Count == 1)
            {
                shopingCartService.RemoveShopping(shopping);
            }
            else
            {
                shopping.Count -= 1;
                shopingCartService.UpdateCart(shopping);
            }

            return RedirectToAction("ListCart");
        }





        public IActionResult PostInformation()
        {
            var AppUser = User.Identity.Name;
            var user = userService.GetByUserName(AppUser);
            var ApUser = mapper.Map<UserViewModel>(user);
            return View(ApUser);
        }

        public IActionResult Send()
        {
            return View();
        }


        public IActionResult Review()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Status = TempData["Status"];
            return View();
        }


        public async Task<IActionResult> Pay(decimal pricepay, string username, int bankid = 0)
        {

            try
            {

                var user = userService.GetByUserName(username);
                var Carts = shopingCartService.GetAllUserById(user.Id);
                var PricSend = weightService.SendPrice(username);
                var Discount = shopingCartService.GetDisCount(username);



                List<int> SumPrice = new List<int>();

                foreach (var item in Carts)
                {
                    SumPrice.Add(Convert.ToInt32(item.Price) * item.Count);
                }
                var SumPay = Convert.ToDecimal(SumPrice.Sum());


                List<int> ListTax = new List<int>();

                foreach (var item in Carts)
                {
                    ListTax.Add(Convert.ToInt32(item.Tax) * item.Count);
                }
                var sumtax = Convert.ToDecimal(ListTax.Sum());


                var amountsent = PricSend;
                var sumall = (Convert.ToInt32(sumtax) + Convert.ToInt32(SumPay) + Convert.ToInt32(amountsent) - Discount);

                if (sumall != pricepay)
                {
                    TempData["Message"] = "Error";
                    TempData["Status"] = "پرداخت نا موفق";
                    return RedirectToAction("Review");
                }

                List<int> lstcount = new List<int>();

                foreach (var item in Carts)
                {
                    lstcount.Add(item.Count);
                }

                var invoice = iinvoiceService.GetInvoiceById(user.Id);

                if (invoice != null)
                {

                    var PriceAmount = Convert.ToInt32(invoice.Price);
                    var payment = new ZarinpalSandbox.Payment(PriceAmount);


                    //string description = ":پرداخت فاکتور " + invoice.InvoiceNumber + "";

                    var res = await payment.PaymentRequest(":پرداخت فاکتور ", "https://localhost:44300/PayVerify/" + user.Id);


                    if (res.Status == 100)
                    {
                        invoice.RefrenceId = res.Authority;

                        iinvoiceService.UpdateInvoice(invoice);


                        return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Authority);
                    }
                    else
                    {
                        return RedirectToAction("Error", new { Code = res.Status });
                    }
                }
                else
                {
                    Random rnd = new Random();

                    int invoices = rnd.Next(10000, 99999) + DateTime.Now.Second + DateTime.Now.Minute + 1;

                    InvoiceDto invoiceDto = new InvoiceDto();
                    invoiceDto.AmountSent = PricSend;
                    invoiceDto.Count = lstcount.Sum();
                    invoiceDto.Date = DateTime.Now;
                    invoiceDto.InvoiceNumber = invoices;
                    invoiceDto.Price = sumall;
                    invoiceDto.Status = false;
                    invoiceDto.Tax = sumtax;
                    invoiceDto.UserId = user.Id;

                    iinvoiceService.AddInvoice(invoiceDto);




                    var PriceAmount = Convert.ToInt32(sumall);

                    var payment = new ZarinpalSandbox.Payment(PriceAmount);

                    var qinvoice = iinvoiceRepository.GetInvUserId(user.Id, invoices);

                    //string description = ":پرداخت فاکتور " + qinvoice.InvoiceNumber + "";

                    var res = await payment.PaymentRequest(":پرداخت فاکتور ", "https://localhost:44300/PayVerify/" + user.Id);


                    if (res.Status == 100)
                    {
                        qinvoice.RefrenceId = res.Authority;

                        iinvoiceRepository.UpdateInvoice(qinvoice);

                        return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Authority);
                    }
                    else
                    {
                        return RedirectToAction("Error", "Home", new { Code = res.Status });
                    }

                }


            }
            catch (Exception)
            {
                TempData["Message"] = "پرداخت نا موفق";
                TempData["Status"] = "NotOk";
                return RedirectToAction("Review");
            }





        }

        [Route("PayVerify/{Id}")]
        public async Task<IActionResult> PayVerify(Guid Id)
        {

            if (HttpContext.Request.Query["status"] != "" &&
                HttpContext.Request.Query["status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var Factor = iinvoiceRepository.InvoiceRefById(Id, authority);

                if (Factor == null)
                    return RedirectToAction("Error", "Home");

                var PriceAmount = Convert.ToInt32(Factor.Price);
                var payment = new ZarinpalSandbox.Payment(PriceAmount);
                var res = await payment.Verification(authority);

                if (res.Status == 100)
                {
                    Factor.Status = true;
                    Factor.TransactionId = res.RefId.ToString();

                    iinvoiceRepository.UpdateInvoice(Factor);

                    var shoping = shopingCartService.GetAllUserById(Factor.UserId);

                    foreach (var item in shoping)
                    {
                        var product = productService.GetById(item.ProductId);
                        var stock = product.Stcok - item.Count;
                        product.Stcok = stock;
                        productService.UpdateProduct(product);

                        item.AmountSent = Factor.AmountSent;
                        item.InvoiceNumber = Factor.InvoiceNumber;
                        item.Status = true;

                        shopingCartService.UpdateCart(item);
                    }

                    try
                    {
                        var use = userService.GetByUserId(Factor.UserId);
                        await emailSender.EmailSenderAsync(use.Email, "پرداخت صورتحساب", + Factor.InvoiceNumber + "  با موفقیت انجام شد. "); 
                        return RedirectToAction("PayComplete", new { invoiceid = Factor.InvoiceId, userid = Factor.UserId });

                    }
                    catch (Exception)
                    {
                        return RedirectToAction("Error", "Home");
                    }

                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }

            }
            else
            {
                return RedirectToAction("Error", "Home");
            }


        }



        public IActionResult PayComplete(Guid userid, int invoiceid)
        {
            try
            {

                var qinvoice = iinvoiceService.GetByIdInvoice(userid, invoiceid);

                if (qinvoice == null)
                    return RedirectToAction("OrderList", "Profile");

                var qshopingcart = shopingCartService.GetListCarts(userid, qinvoice.InvoiceNumber);

                if (qshopingcart.Count() == 0)
                    return RedirectToAction("OrderList", "Profile");

                InvoiceViewModel invoiceViewModel = new InvoiceViewModel();

                invoiceViewModel.ListCarts = qshopingcart == null ? null : qshopingcart;
                invoiceViewModel.RefrenceId = qinvoice.RefrenceId;
                invoiceViewModel.Price = qinvoice.Price;
                invoiceViewModel.Tax = qinvoice.Tax;
                invoiceViewModel.TransactionId = qinvoice.TransactionId;
                invoiceViewModel.AmountSent = qinvoice.AmountSent;
                invoiceViewModel.Date = qinvoice.Date;
                invoiceViewModel.InvoiceId = qinvoice.InvoiceId;

                return View(invoiceViewModel ?? null);
            }
            catch (Exception ex)
            {

                return RedirectToAction("OrderList", "Profile");
            }
        }

    }
}

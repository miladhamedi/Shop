﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Service.Services.Invoices;
using Shop.Core.Service.Services.ShopingCart;
using Shop.Core.Service.Services.User;
using Shop.Core.Service.Services.UserPages;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class InvoiceController : BaseController
    {
        private readonly IinvoiceService iinvoiceService;
        private readonly IMapper mapper;
        private readonly IShopingCartService shopingCartService;
        private readonly IUserPageService userPageService;
        private readonly IUserService userService;

        public InvoiceController(IinvoiceService iinvoiceService,
            IMapper mapper, IShopingCartService shopingCartService,
            
            IUserPageService userPageService,IUserService userService)
        {
            this.iinvoiceService = iinvoiceService;
            this.mapper = mapper;
            this.shopingCartService = shopingCartService;
            this.userPageService = userPageService;
            this.userService = userService;
        }
        public IActionResult Index(int page = 1)
        {
            var Appuser = User.Identity.Name;
            var UserPermission = userPageService.GetPermissionUser(Appuser, "Index", "Invoice");
            if (UserPermission.Count > 0)
            {
                ShopActionResult<List<InvoiceViewModel>> shopActionResult = new ShopActionResult<List<InvoiceViewModel>>();
                var listInvoice = iinvoiceService.GetAllInvoice(page);
                shopActionResult.Page = listInvoice.Page;
                shopActionResult.Pages = listInvoice.Pages;
                List<InvoiceViewModel> invoiceViewModels = new List<InvoiceViewModel>();
                foreach (var item in listInvoice.Data)
                {
                    var invoice = mapper.Map<InvoiceViewModel>(item);

                    invoiceViewModels.Add(invoice);
                }
                shopActionResult.Data = invoiceViewModels;
                return View(shopActionResult);
            }
            else
            {
                return RedirectToAction("NotAccessPage", "User");
            }
          
        }




        public IActionResult InvoiceDetails(int invoicenumber)
        {

            List<ShopingCartViewModel> shopingCartViewModels = new List<ShopingCartViewModel>();
            var ShopingInvoice = shopingCartService.GetByInvoiceId(invoicenumber);
            if (ShopingInvoice == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            foreach (var item in ShopingInvoice)
            {
                var shop = mapper.Map<ShopingCartViewModel>(item);
                shopingCartViewModels.Add(shop);
            }
            return View(shopingCartViewModels);
        }



        public IActionResult StatusInvoice(int invoicenumber,Guid userid)
        {
            var invoice = iinvoiceService.GetStatusProcess(userid, invoicenumber);
            var Invoice = mapper.Map<InvoiceViewModel>(invoice);
            return View(Invoice);
        }
        
        public IActionResult Deliverypost(int invoicenumber, Guid userid)
        {
            var invoice = iinvoiceService.GetStatusProcess(userid, invoicenumber);
            invoice.InvoiceStatus = InvoiceStatus.Deliverypost;
            iinvoiceService.UpdateInvoice(invoice);
            return RedirectToAction("StatusInvoice", new { invoicenumber= invoicenumber, userid= userid });
        }

        public IActionResult Deliverybuyer(int invoicenumber, Guid userid)
        {
            var invoice = iinvoiceService.GetStatusProcess(userid, invoicenumber);
            invoice.InvoiceStatus = InvoiceStatus.Deliverybuyer;
            iinvoiceService.UpdateInvoice(invoice);
            return RedirectToAction("StatusInvoice", new { invoicenumber = invoicenumber, userid = userid });
        }
    }
}

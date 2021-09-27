using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Galleries;
using Shop.Core.Service.Services.Products;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryService galleryService;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IProductService productService;

        public GalleryController(IGalleryService galleryService,
            IMapper mapper, IWebHostEnvironment webHostEnvironment, IProductService productService)
        {
            this.galleryService = galleryService;
            this.mapper = mapper;
            this.webHostEnvironment = webHostEnvironment;
            this.productService = productService;
        }

        public IActionResult Index(int productid)
        {
            var listgallery = galleryService.GetAllProId(productid);
            if (listgallery.Count == 0)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            List<GalleryViewModel> galleryViewModels = new List<GalleryViewModel>();
            foreach (var item in listgallery)
            {
                var gallery = mapper.Map<GalleryViewModel>(item);
                galleryViewModels.Add(gallery);
            }

            return View(galleryViewModels);
        }



        public IActionResult Create(int productid, string returnUrl)
        {
            ViewBag.ProductId = productid;
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(GalleryViewModel model, IFormFile PictureName, string returnUrl)
        {

            if (PictureName.Length > 0)
            {


                if (!Directory.Exists(@"" + webHostEnvironment.WebRootPath + "/uploads/products/"))
                {
                    Directory.CreateDirectory(@"" + webHostEnvironment.WebRootPath + "/uploads/products/");
                }

                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\Products\\");
                var galeryProduct = galleryService.GetAllProId(model.ProductId);
                if (galeryProduct.Count == 0 )
                {
                    Random rnd = new Random();
                    string FileName = "ImgPro-" + rnd.Next(100, 9999) + DateTime.Now.Second * 2 + "." + PictureName.FileName.Split('.').Last();
                    using (var fileStream = new FileStream(Path.Combine(uploads, FileName), FileMode.Create))
                    {
                        PictureName.CopyTo(fileStream);
                    }
                    GalleryDto galleryDto = new GalleryDto();
                    galleryDto.Default = true;
                    galleryDto.ProductId = model.ProductId;
                    galleryDto.PictureName = FileName;
                    galleryDto.Titel = model.Titel;
                    galleryService.AddGallery(galleryDto);
                    if (returnUrl != null)
                    {
                        return RedirectToAction("Index", new { productid = model.ProductId });
                    }
                    else
                    {
                        return RedirectToAction("Create", "ProductColor", new { Productid = model.ProductId });
                    }

                }
                else
                {
                    Random rnd = new Random();
                    string FileName = "ImgPro-" + rnd.Next(100, 9999) + DateTime.Now.Second * 2 + "." + PictureName.FileName.Split('.').Last();
                    using (var fileStream = new FileStream(Path.Combine(uploads, FileName), FileMode.Create))
                    {
                        PictureName.CopyTo(fileStream);
                    }
                    GalleryDto galleryDto = new GalleryDto();
                    galleryDto.Default = false;
                    galleryDto.ProductId = model.ProductId;
                    galleryDto.PictureName = FileName;
                    galleryDto.Titel = model.Titel;
                    var productid = galleryService.AddGallery(galleryDto);
                    return RedirectToAction("Index", new { productid = productid });
                }
            }
            return View(model);

        }

        public IActionResult Edit(int galleryid)
        {
            var gallery = galleryService.GetByGalleryId(galleryid);
            if (gallery == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            var GalleryVi = mapper.Map<GalleryViewModel>(gallery);
            return View(GalleryVi);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(GalleryViewModel model, IFormFile PictureName)
        {
            var gallery = galleryService.GetByGalleryId(model.GalleryId);
            if (gallery == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            if (PictureName != null)
            {
                var uploads = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\Products\\");
                var RoutFile = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\Products\\" + gallery.PictureName);

                if (System.IO.File.Exists(RoutFile))
                {
                    System.IO.File.Delete(RoutFile);
                }

                Random rnd = new Random();

                string FileName = "ImgPro-" + rnd.Next(100, 9999) + DateTime.Now.Second * 2 + "." + PictureName.FileName.Split('.').Last();
                using (var fileStream = new FileStream(Path.Combine(uploads, FileName), FileMode.Create))
                {
                    PictureName.CopyTo(fileStream);
                }

                gallery.PictureName = model.Titel;
                gallery.PictureName = FileName;
                galleryService.UpdateGallery(gallery);
                return RedirectToAction("Index", new { productid = gallery.ProductId });
            }
            else
            {
                gallery.PictureName = model.Titel;
                galleryService.UpdateGallery(gallery);
                return RedirectToAction("Index", new { productid = gallery.ProductId });
            }
          


        }


        public IActionResult Delete(int galleryid)
        {
            var gallery = galleryService.GetByGalleryId(galleryid);
            if (gallery == null)
            {
                return RedirectToAction("Notfound", "Manage");
            }
            var RoutFile = Path.Combine(webHostEnvironment.WebRootPath, "uploads\\Products\\" + gallery.PictureName);

            if (System.IO.File.Exists(RoutFile))
            {
                System.IO.File.Delete(RoutFile);
            }
            galleryService.RemoveGallery(gallery);
            return RedirectToAction("Index", new { productid = gallery.ProductId });
        }
    }
}

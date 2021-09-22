using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Categories;
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository categoryRepository,
            ICategoryService  categoryService,IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<CategoryViewModel>> actionResult = new ShopActionResult<List<CategoryViewModel>>();
            var Listcategory = categoryService.GetAll(page);
            actionResult.Pages = Listcategory.Pages;
            actionResult.Page = page;
            List<CategoryViewModel> categoryViewModels = new List<CategoryViewModel>();
            foreach (var item in Listcategory.Data)
            {
                var category = mapper.Map<CategoryViewModel>(item);
                categoryViewModels.Add(category);
            }
            actionResult.Data = categoryViewModels;


            return View(actionResult);
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var category = mapper.Map<CategoryDto>(model);

                categoryService.AddCategory(category);

                return RedirectToAction("Index");
            }
            return View(model);
        }


        public IActionResult Edit(int id)
        {
            var category = categoryService.GetById(id);
            if (category == null)
            {
                return View("Error","Home");
            }

            var Category = mapper.Map<CategoryViewModel>(category);

            return View(Category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel model)
        {

            if (ModelState.IsValid)
            {
                //repository
                var Category = categoryRepository.GetById(model.CategoryId);

                Category.ActivePassive = model.ActivePassive;
                Category.Titel = model.Titel;

                //repository
                categoryRepository.UpdateCategory(Category);

                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}

using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Services.Colors;
using Shop.Core.Service.Services.Comments;
using Shop.Core.Service.Services.Galleries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        private readonly ICommentRepository commentRepository;
        private readonly ITechnicalDetailRepository technicalDetailRepository;
        private readonly IGalleryService galleryService;
        private readonly ICommentService commentService;
        private readonly IColorService colorService;

        public ProductService(IProductRepository productRepository, IMapper mapper,ICommentRepository commentRepository,
            
            ITechnicalDetailRepository technicalDetailRepository, 
            IGalleryService galleryService, 
            ICommentService commentService, 
            IColorService colorService)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
            this.commentRepository = commentRepository;
            this.technicalDetailRepository = technicalDetailRepository;
            this.galleryService = galleryService;
            this.commentService = commentService;
            this.colorService = colorService;
        }

        public int AddProduct(ProductDto product)
        {
            var pro = mapper.Map<Product>(product);
            productRepository.AddProduct(pro);
            return pro.ProductId;
        }

        public ShopActionResult<List<ProductDto>> GetAllProduct(int page = 1)
        {
            ShopActionResult<List<ProductDto>> prolistor = new ShopActionResult<List<ProductDto>>();

            var prolist = productRepository.GetAllProduct();

            prolistor.ItemCount = 10;
            prolistor.Page = page;
            var Allpage = prolist.Count;

            var skip = (prolistor.Page - 1) * prolistor.ItemCount;
            var ProList = prolist.Skip(skip).Take(prolistor.ItemCount);
            prolistor.Pages = Convert.ToInt32(Math.Ceiling((decimal)Allpage / prolistor.ItemCount));


            List<ProductDto> productAdminDtos  = new List<ProductDto>();

            foreach (var item in ProList)
            {
                var ListPro = mapper.Map<ProductDto>(item);

                productAdminDtos.Add(ListPro);

            }
            prolistor.Data = productAdminDtos;

            return prolistor;
        }

        public ProductDto GetById(int productid)
        {
            var user = productRepository.GetById(productid);
            var AppUser = mapper.Map<ProductDto>(user);
            return AppUser;
        }

        public ProductDto GetByIdPro(int productid)
        {
            var user = productRepository.GetProductById(productid);
            var AppUser = mapper.Map<ProductDto>(user);
            return AppUser;
        }

        public decimal PriceDiscount(decimal price, decimal discountpercent)
        {
            var DiscountPercent = Convert.ToInt32(price) * discountpercent;
            var discountPr = DiscountPercent / 100;
            var pricedis = Convert.ToInt32(price) - discountPr;
            return pricedis;
        }

        public ShopActionResult<List<ProductByCateDto>> ProductByCatelist(int categoryid, int page = 1)
        {
            ShopActionResult<List<ProductByCateDto>> prolistor = new ShopActionResult<List<ProductByCateDto>>();

            var prolistCate = productRepository.GetByCategoryId(categoryid);

            prolistor.ItemCount = 9;
            prolistor.Page = page;
            var Allpage = prolistCate.Count;

            var skip = (page - 1) * prolistor.ItemCount;
            var ProCatList = prolistCate.Skip(skip).Take(prolistor.ItemCount);
            prolistor.Pages = Convert.ToInt32(Math.Ceiling((decimal)Allpage / prolistor.ItemCount));


             List < ProductByCateDto > productByCateDtos = new List<ProductByCateDto>();

            foreach (var item in ProCatList)
            {
                var ListProCate = mapper.Map<ProductByCateDto>(item);

                productByCateDtos.Add(ListProCate);

            }
            prolistor.Data = productByCateDtos;
           

            return prolistor;
        }

        public ProductDetailsDto ProductDetails(int productid)
        {
            var product = productRepository.GetProductById(productid);
            var tchnic = technicalDetailRepository.GetByProductId(product.ProductId);
            var ListColor = colorService.GetByProductColor(product.ProductId);
            var ListComment = commentService.GetAllProId(product.ProductId);
            var ListGallery = galleryService.GetAllProId(product.ProductId);
           

            ProductDetailsDto productDto = new ProductDetailsDto();
            productDto.ProductId = product.ProductId;
            productDto.Description = product.Description;
            productDto.Title = product.Titel;
            productDto.Price = product.Price;
            productDto.PriceDisCount = product.DiscuntedPrice;
            productDto.DiscountPercent = product.DiscuntPercent;
            productDto.Stock = product.Stcok;
            productDto.Warranty = tchnic.Warranty;
            productDto.ProductionYear = tchnic.ProductionYear;
            productDto.ManufacturingCountry = tchnic.ManufacturingCountry;
            productDto.Manufacturer = tchnic.Manufacturer;
            productDto.Date = product.Date;
            productDto.Type = tchnic.Type;
            productDto.Model = tchnic.Model;
            productDto.ProductId = product.ProductId;
            productDto.ColorDtos = ListColor;
            productDto.CommentDtos = ListComment;
            productDto.GalleryDtos = ListGallery;
            productDto.View = product.Visit += 1;

            productRepository.UpdateProduct(product);


            return productDto;


        }

        public ShopActionResult<List<ProductByCateDto>> SearchPrice(int categoryid,decimal min_price, decimal max_price, int page = 1)
        {
            var listpro = productRepository.searchPrice(categoryid,min_price, max_price);

            ShopActionResult<List<ProductByCateDto>> shopActionResult = new ShopActionResult<List<ProductByCateDto>>();
            List<ProductByCateDto> productByCateDtos = new List<ProductByCateDto>();
            shopActionResult.Counts = listpro.Count();
            shopActionResult.ItemCount = 3;
            shopActionResult.Page = page;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var ListProduct = listpro.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            foreach (var item in ListProduct)
            {

                var ListPro = mapper.Map<ProductByCateDto>(item);

                productByCateDtos.Add(ListPro);

            }

            shopActionResult.Data = productByCateDtos;

            return shopActionResult;
        }

        public ShopActionResult<List<ProductByCateDto>> SearchProduct(string title ,int page = 1)
        {

            var listProduct = productRepository.SearchProduct(title);
            ShopActionResult<List<ProductByCateDto>> shopActionResult = new ShopActionResult<List<ProductByCateDto>>();
            List<ProductByCateDto> productByCateDtos = new List<ProductByCateDto>();
            shopActionResult.Counts = listProduct.Count();
            shopActionResult.ItemCount = 3;
            shopActionResult.Page = page;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var ListProduct = listProduct.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            foreach (var item in ListProduct)
            {

               var ListPro = mapper.Map<ProductByCateDto>(item);

                productByCateDtos.Add(ListPro);

            }

            shopActionResult.Data = productByCateDtos;

            return shopActionResult;
        }

        public void UpdateProduct(ProductDto product)
        {
            var pro = mapper.Map<Product>(product);
            productRepository.UpdateProduct(pro);
        }
    }
}

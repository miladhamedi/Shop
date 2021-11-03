using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Shop.Common;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<IdentityUserRole<Guid>, UserRoleDto>();
            CreateMap<UserRoleDto, UserRoleViewModel>();
            CreateMap<Color, ColorDto>();
            CreateMap<ColorDto, ColorViewModel>();
            CreateMap<ColorViewModel, ColorDto>();
            CreateMap<ColorDto, Color>();
            CreateMap<Article, ArticleDto>();
            CreateMap<ArticleDto, Article>();
            CreateMap<ArticleDto, ArticleViewModel>();
            CreateMap<Article, ArticleViewModel>();
            CreateMap<MessageDto, Message>();
            CreateMap<Message, MessageDto>();
            CreateMap<MessageDto, MessageViewModel>();
            CreateMap<MessageViewModel, MessageDto>();
            CreateMap<Gallery, GalleryDto>();
            CreateMap<GalleryDto, Gallery>();
            CreateMap<Setting, SettingDto>();
            CreateMap<UserPage, UserPageDto>();
            CreateMap<UserPageDto, UserPage>();
            CreateMap<UserPageDto, UserPageViewModel>();
            CreateMap<UserPageViewModel, UserPageDto>();
            CreateMap<Weight, WeightDto>();
            CreateMap<ColorProductDto, ColorProductViewModel>();
            CreateMap<WeightDto, Weight>();
            CreateMap<WeightDto, WeightViewModel>();
            CreateMap<WeightViewModel, WeightDto>();
            CreateMap<Color, ColorDto>();
            CreateMap<ProductByCateDto, ProductByCateViewModel>();
            CreateMap<UserDto, ApplicationUser>();
            CreateMap<ApplicationUser, UserDto>();
            CreateMap<UserDto, UserViewModel>();
            CreateMap<InvoiceDto, Invoice>();
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<ProductDetailsDto, ProductDetailsViewModel>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<GalleryDto, GalleryViewModel>()
                .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
                .ForMember(c =>
          c.Titel,
          opt => opt.MapFrom(src => src.Titel))
      .ForMember(c =>
          c.PictureName,
          opt => opt.MapFrom(src => src.PictureName))
       .ForMember(c =>
          c.GalleryId,
          opt => opt.MapFrom(src => src.GalleryId));

            
            CreateMap<CommentDto, Comment>()
                .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
                .ForMember(c =>
          c.CommentId,
          opt => opt.MapFrom(src => src.CommentId))
      .ForMember(c =>
          c.Confirm,
          opt => opt.MapFrom(src => src.Confirm))
       .ForMember(c =>
          c.Date,
          opt => opt.MapFrom(src => src.Date))
        .ForMember(c =>
          c.Email,
          opt => opt.MapFrom(src => src.Email))
        .ForMember(c =>
          c.IP,
          opt => opt.MapFrom(src => src.IP))
        .ForMember(c =>
          c.NameFamily,
          opt => opt.MapFrom(src => src.NameFamily))
        .ForMember(c =>
          c.Text,
          opt => opt.MapFrom(src => src.Text))
        .ForMember(c =>
          c.UserId,
          opt => opt.MapFrom(src => src.UserId));

            CreateMap<Comment, CommentDto>()
              .ForMember(c =>
        c.ProductId,
        opt => opt.MapFrom(src => src.ProductId))

              .ForMember(c =>
        c.CommentId,
        opt => opt.MapFrom(src => src.CommentId))
    .ForMember(c =>
        c.Confirm,
        opt => opt.MapFrom(src => src.Confirm))
     .ForMember(c =>
        c.Date,
        opt => opt.MapFrom(src => src.Date))
      .ForMember(c =>
        c.Email,
        opt => opt.MapFrom(src => src.Email))
      .ForMember(c =>
        c.IP,
        opt => opt.MapFrom(src => src.IP))
      .ForMember(c =>
        c.NameFamily,
        opt => opt.MapFrom(src => src.NameFamily))
      .ForMember(c =>
        c.Text,
        opt => opt.MapFrom(src => src.Text))
      .ForMember(c =>
        c.UserId,
        opt => opt.MapFrom(src => src.UserId));

            CreateMap<CommentDto, CommentViewModel>()
             .ForMember(c =>
       c.ProductId,
       opt => opt.MapFrom(src => src.ProductId))

             .ForMember(c =>
       c.CommentId,
       opt => opt.MapFrom(src => src.CommentId))
   .ForMember(c =>
       c.Confirm,
       opt => opt.MapFrom(src => src.Confirm))
    .ForMember(c =>
       c.Date,
       opt => opt.MapFrom(src => src.Date))
     .ForMember(c =>
       c.Email,
       opt => opt.MapFrom(src => src.Email))
     .ForMember(c =>
       c.IP,
       opt => opt.MapFrom(src => src.IP))
     .ForMember(c =>
       c.NameFamily,
       opt => opt.MapFrom(src => src.NameFamily))
     .ForMember(c =>
       c.Text,
       opt => opt.MapFrom(src => src.Text))
     .ForMember(c =>
       c.UserId,
       opt => opt.MapFrom(src => src.UserId));

           

            CreateMap<Category, CategoryDto>()
                .ForMember(c =>
         c.CategoryId,
           opt => opt.MapFrom(src => src.CategoryId))
       .ForMember(c =>
           c.Titel,
           opt => opt.MapFrom(src => src.Titel))
        .ForMember(c =>
           c.ActivePassive,
           opt => opt.MapFrom(src => src.ActivePassive));

            CreateMap<ProductColor, ProductColorDto>()
               .ForMember(c =>
        c.ColorId,
          opt => opt.MapFrom(src => src.ColorId))
      .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
      .ForMember(c =>
          c.ProductColorId,
          opt => opt.MapFrom(src => src.ProductColorId));


            CreateMap<ProductColorDto, ProductColor>()
             .ForMember(c =>
        c.ColorId,
          opt => opt.MapFrom(src => src.ColorId))
      .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
      .ForMember(c =>
          c.ProductColorId,
          opt => opt.MapFrom(src => src.ProductColorId));

            CreateMap<ProductColorDto, ProductColorViewModel>()
                .ForMember(c =>
        c.ColorId,
          opt => opt.MapFrom(src => src.ColorId))
      .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
      .ForMember(c =>
          c.ProductColorId,
          opt => opt.MapFrom(src => src.ProductColorId));

            CreateMap<ProductColorViewModel, ProductColorDto>()
                  .ForMember(c =>
           c.ColorId,
             opt => opt.MapFrom(src => src.ColorId))
         .ForMember(c =>
             c.ProductId,
             opt => opt.MapFrom(src => src.ProductId))
          .ForMember(c =>
          c.ProductColorId,
          opt => opt.MapFrom(src => src.ProductColorId));

            CreateMap<CategoryDto, Category>()
                .ForMember(c =>
         c.CategoryId,
           opt => opt.MapFrom(src => src.CategoryId))
       .ForMember(c =>
           c.Titel,
           opt => opt.MapFrom(src => src.Titel))
        .ForMember(c =>
           c.ActivePassive,
           opt => opt.MapFrom(src => src.ActivePassive));

            CreateMap<CategoryDto, CategoryViewModel>()
              .ForMember(c =>
       c.CategoryId,
         opt => opt.MapFrom(src => src.CategoryId))
     .ForMember(c =>
         c.Titel,
         opt => opt.MapFrom(src => src.Titel))
      .ForMember(c =>
         c.ActivePassive,
         opt => opt.MapFrom(src => src.ActivePassive));

            CreateMap<CategoryViewModel, CategoryDto>()
            .ForMember(c =>
     c.CategoryId,
       opt => opt.MapFrom(src => src.CategoryId))
   .ForMember(c =>
       c.Titel,
       opt => opt.MapFrom(src => src.Titel))
    .ForMember(c =>
       c.ActivePassive,
       opt => opt.MapFrom(src => src.ActivePassive));


          
            CreateMap<IdentityRole<Guid>, RoleDto>()
      .ForMember(c =>
          c.RoleId,
          opt => opt.MapFrom(src => src.Id))
      .ForMember(c =>
          c.RoleName,
          opt => opt.MapFrom(src => src.Name));
            CreateMap<RoleDto, IdentityRole<Guid>>()
     .ForMember(c =>
         c.Id,
         opt => opt.MapFrom(src => src.RoleId))
     .ForMember(c =>
         c.Name,
         opt => opt.MapFrom(src => src.RoleName));

            CreateMap<RoleDto, RoleViewModel>()
      .ForMember(c =>
          c.RoleId,
          opt => opt.MapFrom(src => src.RoleId))
      .ForMember(c =>
          c.RoleName,
          opt => opt.MapFrom(src => src.RoleName));

            CreateMap<Product, InexpensiveProIndexDto>()
       .ForMember(c =>
           c.ProductId,
           opt => opt.MapFrom(src => src.ProductId))
       .ForMember(c =>
           c.Title,
           opt => opt.MapFrom(src => src.Titel))
        .ForMember(c =>
           c.Picture,
           opt => opt.MapFrom(src => src.Galleries.First().PictureName));

            CreateMap<TechnicalDetail, TechnicalDetailDto>()
      .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
      .ForMember(c =>
          c.Manufacturer,
          opt => opt.MapFrom(src => src.Manufacturer))
       .ForMember(c =>
          c.ManufacturingCountry,
          opt => opt.MapFrom(src => src.ManufacturingCountry))
        .ForMember(c =>
          c.Model,
          opt => opt.MapFrom(src => src.Model))
         .ForMember(c =>
          c.ProductionYear,
          opt => opt.MapFrom(src => src.ProductionYear))
          .ForMember(c =>
          c.ManufacturingCountry,
          opt => opt.MapFrom(src => src.ManufacturingCountry))
           .ForMember(c =>
          c.Warranty,
          opt => opt.MapFrom(src => src.Warranty))
            .ForMember(c =>
          c.TechnicalDetailId,
          opt => opt.MapFrom(src => src.TechnicalDetailId));

            CreateMap<TechnicalDetailDto, TechnicalDetail>()
     .ForMember(c =>
         c.ProductId,
         opt => opt.MapFrom(src => src.ProductId))
     .ForMember(c =>
         c.Manufacturer,
         opt => opt.MapFrom(src => src.Manufacturer))
      .ForMember(c =>
         c.ManufacturingCountry,
         opt => opt.MapFrom(src => src.ManufacturingCountry))
       .ForMember(c =>
         c.Model,
         opt => opt.MapFrom(src => src.Model))
        .ForMember(c =>
         c.ProductionYear,
         opt => opt.MapFrom(src => src.ProductionYear))
         .ForMember(c =>
         c.ManufacturingCountry,
         opt => opt.MapFrom(src => src.ManufacturingCountry))
          .ForMember(c =>
         c.Warranty,
         opt => opt.MapFrom(src => src.Warranty))
           .ForMember(c =>
         c.TechnicalDetailId,
         opt => opt.MapFrom(src => src.TechnicalDetailId));

            CreateMap<TechnicalDetailDto, TechnicalDetailViewModel>()
     .ForMember(c =>
         c.ProductId,
         opt => opt.MapFrom(src => src.ProductId))
     .ForMember(c =>
         c.Manufacturer,
         opt => opt.MapFrom(src => src.Manufacturer))
      .ForMember(c =>
         c.ManufacturingCountry,
         opt => opt.MapFrom(src => src.ManufacturingCountry))
       .ForMember(c =>
         c.Model,
         opt => opt.MapFrom(src => src.Model))
        .ForMember(c =>
         c.ProductionYear,
         opt => opt.MapFrom(src => src.ProductionYear))
         .ForMember(c =>
         c.ManufacturingCountry,
         opt => opt.MapFrom(src => src.ManufacturingCountry))
          .ForMember(c =>
         c.Warranty,
         opt => opt.MapFrom(src => src.Warranty))
           .ForMember(c =>
         c.TechnicalDetailId,
         opt => opt.MapFrom(src => src.TechnicalDetailId));

            CreateMap<TechnicalDetailViewModel, TechnicalDetailDto>()
    .ForMember(c =>
        c.ProductId,
        opt => opt.MapFrom(src => src.ProductId))
    .ForMember(c =>
        c.Manufacturer,
        opt => opt.MapFrom(src => src.Manufacturer))
     .ForMember(c =>
        c.ManufacturingCountry,
        opt => opt.MapFrom(src => src.ManufacturingCountry))
      .ForMember(c =>
        c.Model,
        opt => opt.MapFrom(src => src.Model))
       .ForMember(c =>
        c.ProductionYear,
        opt => opt.MapFrom(src => src.ProductionYear))
        .ForMember(c =>
        c.ManufacturingCountry,
        opt => opt.MapFrom(src => src.ManufacturingCountry))
         .ForMember(c =>
        c.Warranty,
        opt => opt.MapFrom(src => src.Warranty))
          .ForMember(c =>
        c.TechnicalDetailId,
        opt => opt.MapFrom(src => src.TechnicalDetailId));





            CreateMap<Product, NewProductDto>()
      .ForMember(c =>
          c.ProductId,
          opt => opt.MapFrom(src => src.ProductId))
       .ForMember(c =>
           c.DisCountPercent,
           opt => opt.MapFrom(src => src.DiscuntPercent))
      .ForMember(c =>
          c.Title,
          opt => opt.MapFrom(src => src.Titel))
       .ForMember(c =>
          c.Picture,
          opt => opt.MapFrom(src => src.Galleries.First().PictureName))
        .ForMember(c =>
          c.Price,
          opt => opt.MapFrom(src => src.Price))
        .ForMember(c =>
          c.PriceDiscount,
          opt => opt.MapFrom(src => src.DiscuntedPrice));



            CreateMap<ShopingCartDto, ShoppingCart>()
   .ForMember(c =>
       c.ProductId,
       opt => opt.MapFrom(src => src.ProductId))
    .ForMember(c =>
         c.ShoppingCartId,
         opt => opt.MapFrom(src => src.ShoppingCartId))
   .ForMember(c =>
       c.InvoiceNumber,
       opt => opt.MapFrom(src => src.InvoiceNumber))
   .ForMember(c =>
       c.UserId,
       opt => opt.MapFrom(src => src.UserId))
    .ForMember(c =>
       c.Warranty,
       opt => opt.MapFrom(src => src.Warranty))
     .ForMember(c =>
       c.Tax,
       opt => opt.MapFrom(src => src.Tax))
      .ForMember(c =>
       c.AmountSent,
       opt => opt.MapFrom(src => src.AmountSent))
       .ForMember(c =>
       c.Count,
       opt => opt.MapFrom(src => src.Count))
        .ForMember(c =>
       c.Date,
       opt => opt.MapFrom(src => src.Date))
         .ForMember(c =>
       c.InvoiceNumber,
       opt => opt.MapFrom(src => src.InvoiceNumber))
           .ForMember(c =>
       c.Status,
       opt => opt.MapFrom(src => src.Status))
     .ForMember(c =>
       c.ProductCode,
       opt => opt.MapFrom(src => src.ProductCode));


            CreateMap<ShoppingCart, ShopingCartDto>()
     .ForMember(c =>
         c.ProductId,
         opt => opt.MapFrom(src => src.ProductId))
     .ForMember(c =>
         c.ShoppingCartId,
         opt => opt.MapFrom(src => src.ShoppingCartId))
     .ForMember(c =>
         c.InvoiceNumber,
         opt => opt.MapFrom(src => src.InvoiceNumber))
     .ForMember(c =>
         c.UserId,
         opt => opt.MapFrom(src => src.UserId))
      .ForMember(c =>
         c.Warranty,
         opt => opt.MapFrom(src => src.Warranty))
       .ForMember(c =>
         c.Tax,
         opt => opt.MapFrom(src => src.Tax))
        .ForMember(c =>
         c.AmountSent,
         opt => opt.MapFrom(src => src.AmountSent))
         .ForMember(c =>
         c.Count,
         opt => opt.MapFrom(src => src.Count))
          .ForMember(c =>
         c.Date,
         opt => opt.MapFrom(src => src.Date))
           .ForMember(c =>
         c.InvoiceNumber,
         opt => opt.MapFrom(src => src.InvoiceNumber))
             .ForMember(c =>
         c.Status,
         opt => opt.MapFrom(src => src.Status))
       .ForMember(c =>
         c.ProductCode,
         opt => opt.MapFrom(src => src.ProductCode));


            CreateMap<ShopingCartDto, ShopingCartViewModel>()
   .ForMember(c =>
         c.ProductId,
         opt => opt.MapFrom(src => src.ProductId))
   .ForMember(c =>
         c.ShoppingCartId,
         opt => opt.MapFrom(src => src.ShoppingCartId))
     .ForMember(c =>
         c.InvoiceNumber,
         opt => opt.MapFrom(src => src.InvoiceNumber))
     .ForMember(c =>
         c.UserId,
         opt => opt.MapFrom(src => src.UserId))
      .ForMember(c =>
         c.Warranty,
         opt => opt.MapFrom(src => src.Warranty))
       .ForMember(c =>
         c.Tax,
         opt => opt.MapFrom(src => src.Tax))
        .ForMember(c =>
         c.AmountSent,
         opt => opt.MapFrom(src => src.AmountSent))
         .ForMember(c =>
         c.Count,
         opt => opt.MapFrom(src => src.Count))
          .ForMember(c =>
         c.Date,
         opt => opt.MapFrom(src => src.Date))
           .ForMember(c =>
         c.InvoiceNumber,
         opt => opt.MapFrom(src => src.InvoiceNumber))
             .ForMember(c =>
         c.Status,
         opt => opt.MapFrom(src => src.Status))
       .ForMember(c =>
         c.ProductCode,
         opt => opt.MapFrom(src => src.ProductCode));





            CreateMap<ShoppingCart, BestsellingDto>()
  .ForMember(c =>
      c.ProductId,
      opt => opt.MapFrom(src => src.ProductId))
   .ForMember(c =>
           c.DisCountPercent,
           opt => opt.MapFrom(src => src.Product.DiscuntPercent))
  .ForMember(c =>
      c.Title,
      opt => opt.MapFrom(src => src.Product.Titel))
   .ForMember(c =>
      c.Price,
      opt => opt.MapFrom(src => src.Product.Price))
    .ForMember(c =>
      c.DiscountPrice,
      opt => opt.MapFrom(src => src.Product.DiscuntedPrice))
    .ForMember(c =>
      c.Picture,
      opt => opt.MapFrom(src => src.Product.Galleries.First().PictureName));


            CreateMap<Product, ProductByCateDto>()
     .ForMember(c =>
         c.ProductId,
         opt => opt.MapFrom(src => src.ProductId))
     .ForMember(c =>
         c.Title,
         opt => opt.MapFrom(src => src.Titel))
     .ForMember(c =>
         c.DisCountPercent,
         opt => opt.MapFrom(src => src.DiscuntPercent))
      .ForMember(c =>
         c.Picture,
         opt => opt.MapFrom(src => src.Galleries.First().PictureName))
      .ForMember(c =>
         c.Price,
         opt => opt.MapFrom(src => src.Price))
      .ForMember(c =>
         c.CategoryId,
         opt => opt.MapFrom(src => src.CategoryId))
       .ForMember(c =>
         c.DisCountPrice,
         opt => opt.MapFrom(src => src.DiscuntedPrice));

           
            CreateMap<ApplicationUser, PostInformationDto>()
     .ForMember(c =>
  c.City,
  opt => opt.MapFrom(src => src.City))
     .ForMember(c =>
  c.Province,
  opt => opt.MapFrom(src => src.Province))
    .ForMember(c =>
  c.PostalCode,
  opt => opt.MapFrom(src => src.PostalCode))
    .ForMember(c =>
  c.Address,
  opt => opt.MapFrom(src => src.Address))
     .ForMember(c =>
  c.IrCode,
  opt => opt.MapFrom(src => src.IrCode))
    .ForMember(c =>
  c.NameFamily,
  opt => opt.MapFrom(src => src.NameFamily))
     .ForMember(c =>
  c.PnoneNumber,
  opt => opt.MapFrom(src => src.PhoneNumber));



            CreateMap<MessageDto, MessageViewModel>()
     .ForMember(c =>
         c.Text,
         opt => opt.MapFrom(src => src.Text))
     .ForMember(c =>
         c.UserIdRecive,
         opt => opt.MapFrom(src => src.UserIdRecive))
      .ForMember(c =>
         c.UserIdSend,
         opt => opt.MapFrom(src => src.UserIdSend))
      .ForMember(c =>
         c.Confirm,
         opt => opt.MapFrom(src => src.Confirm))
      .ForMember(c =>
         c.Date,
         opt => opt.MapFrom(src => src.Date));
           
            CreateMap<InvoiceDto, InvoiceViewModel>()
  .ForMember(c =>
      c.InvoiceNumber,
      opt => opt.MapFrom(src => src.InvoiceNumber))
  .ForMember(c =>
      c.InvoiceId,
      opt => opt.MapFrom(src => src.InvoiceId))
   .ForMember(c =>
      c.UserId,
      opt => opt.MapFrom(src => src.UserId))
   .ForMember(c =>
      c.Status,
      opt => opt.MapFrom(src => src.Status))
   .ForMember(c =>
      c.InvoiceStatus,
      opt => opt.MapFrom(src => src.InvoiceStatus))
   .ForMember(c =>
      c.AmountSent,
      opt => opt.MapFrom(src => src.AmountSent))
   .ForMember(c =>
      c.Tax,
      opt => opt.MapFrom(src => src.Tax))
   .ForMember(c =>
      c.Date,
      opt => opt.MapFrom(src => src.Date))
   .ForMember(c =>
      c.Count,
      opt => opt.MapFrom(src => src.Count))
    .ForMember(c =>
      c.TransactionId,
      opt => opt.MapFrom(src => src.TransactionId))
     .ForMember(c =>
      c.RefrenceId,
      opt => opt.MapFrom(src => src.RefrenceId))
   .ForMember(c =>
      c.Price,
      opt => opt.MapFrom(src => src.Price));






        }
    }
}
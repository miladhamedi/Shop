using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class GalleryRepository: IGalleryRepository
    {
        private readonly ShopDbContext shopDbContext;

        public GalleryRepository(ShopDbContext shopDbContext )
        {
            this.shopDbContext = shopDbContext;
        }

        public int AddGallery(Gallery gallery)
        {
            shopDbContext.Galleries.Add(gallery);
            shopDbContext.SaveChanges();
            return gallery.ProductId;
        }

      

        public List<Gallery> GetAllProId(int productid)
        {
            var gallery = shopDbContext.Galleries.Where(c => c.ProductId == productid).AsNoTracking().ToList();
            return gallery;
        }

       

        //public Gallery GetById(int Galleryid)
        //{
        //    var gallery = shopDbContext.Galleries.Where(c => c.Default == false).SingleOrDefault(c => c.GalleryId == Galleryid);
        //    return gallery;
              
        //}

        public Gallery GetByIdGallery(int Galleryid)
        {
            var gallery = shopDbContext.Galleries.Where(c => c.GalleryId == Galleryid).AsNoTracking().FirstOrDefault();
            return gallery;
        }

        public string GetPicName(int productid)
        {
            var ImgName = shopDbContext.Galleries.Where(c => c.ProductId == productid && c.Default == true).FirstOrDefault().PictureName;

            return ImgName;
        }

        public void RemoveGallery(Gallery gallery)
        {
            shopDbContext.Galleries.Remove(gallery);
            shopDbContext.SaveChanges();

        }

        public void UpdateGallery(Gallery gallery)
        {
            shopDbContext.Galleries.Attach(gallery);
            shopDbContext.Entry(gallery).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}

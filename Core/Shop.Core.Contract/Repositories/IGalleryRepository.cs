using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IGalleryRepository
    {
        string GetPicName(int productid);
        List<Gallery> GetAllProId(int productid);
        int AddGallery(Gallery gallery);
        Gallery GetByGalleryId(int Galleryid);
        void RemoveGallery(Gallery gallery);
        void UpdateGallery(Gallery gallery);

    }
}

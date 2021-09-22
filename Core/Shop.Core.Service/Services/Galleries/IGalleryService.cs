using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Galleries
{
    public interface IGalleryService
    {
        List<GalleryDto> GetAllProId(int productid);
        string GetPicName(int productid);
        int AddGallery(GalleryDto galleryDto);
        void RemoveGallery(GalleryDto galleryDto);
        GalleryDto GetByGalleryId(int galleryid);
        void UpdateGallery(GalleryDto galleryDto );
    }
}

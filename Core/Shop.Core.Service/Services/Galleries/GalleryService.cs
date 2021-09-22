using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Galleries
{
    public class GalleryService : IGalleryService
    {
        private readonly IGalleryRepository galleryRepository;
        private readonly IMapper mapper;

        public GalleryService(IGalleryRepository galleryRepository, IMapper mapper)
        {
            this.galleryRepository = galleryRepository;
            this.mapper = mapper;
        }

        public int AddGallery(GalleryDto galleryDto)
        {
            var gallery = mapper.Map<Gallery>(galleryDto);
            galleryRepository.AddGallery(gallery);
            return galleryDto.ProductId;
        }

        public List<GalleryDto> GetAllProId(int productid)
        {
            var listGallery = galleryRepository.GetAllProId(productid);
            List<GalleryDto> galleryDtos = new List<GalleryDto>();
            foreach (var item in listGallery)
            {
                var gallerylist = mapper.Map<GalleryDto>(item);
                galleryDtos.Add(gallerylist);
            }
            return galleryDtos;
        }

        public GalleryDto GetByGalleryId(int galleryid)
        {
            var gallery = galleryRepository.GetByIdGallery(galleryid);
            var Gallery = mapper.Map<GalleryDto>(gallery);
            return Gallery;
        }

        public string GetPicName(int productid)
        {
            var PicName = galleryRepository.GetPicName(productid);
            return PicName;
        }

        public void RemoveGallery(GalleryDto galleryDto)
        {
            var gallery = mapper.Map<Gallery>(galleryDto);
            galleryRepository.RemoveGallery(gallery);
        }

        public void UpdateGallery(GalleryDto galleryDto)
        {
            var gallery = mapper.Map<Gallery>(galleryDto);
            galleryRepository.UpdateGallery(gallery);
        }
    }
}

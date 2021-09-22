using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.ProductColors
{
    public class ProductColorService : IProductColorService
    {
        private readonly IProductColorRepository productColorRepository;
        private readonly IMapper mapper;

        public ProductColorService(IProductColorRepository productColorRepository,IMapper mapper)
        {
            this.productColorRepository = productColorRepository;
            this.mapper = mapper;
        }
        public void AddProductColor(ProductColorDto productColorDto)
        {
            var productcolor = mapper.Map<ProductColor>(productColorDto);
            productColorRepository.AddProductColor(productcolor);
        }

        public List<ProductColorDto> AllColorProId(int productid)
        {
            List<ProductColorDto> productColorDtos = new List<ProductColorDto>();
            var productcolor = productColorRepository.AllColorProId(productid);
            foreach (var item in productcolor)
            {
                var procolor = mapper.Map<ProductColorDto>(item);
                productColorDtos.Add(procolor);
            }
            return productColorDtos;
        }

        public ProductColorDto GetByColorId(int colorid)
        {
            var color = productColorRepository.GetByColorId(colorid);
            var Color = mapper.Map<ProductColorDto>(color);
            return Color;
        }

        public ProductColorDto GetByProColorId(int productcolorid)
        {
            var procolor = productColorRepository.GetByProColorId(productcolorid);
            var ProductColor = mapper.Map<ProductColorDto>(procolor);
            return ProductColor;
        }

        public ProductColorDto GetColorByProductId(int colorid, int productid)
        {
            var productColor = productColorRepository.GetColorByProductId(colorid, productid);
            var ProColor = mapper.Map<ProductColorDto>(productColor);
            return ProColor;
        }

        public void RemoveProductCololr(ProductColorDto productColorDto)
        {
            var productcolor = mapper.Map<ProductColor>(productColorDto);
            productColorRepository.RemoveProductCololr(productcolor);
        }

        public void UpdateProColor(ProductColorDto productColorDto)
        {
            var productcolor = mapper.Map<ProductColor>(productColorDto);
            productColorRepository.UpdateProColor(productcolor);
        }
    }
}

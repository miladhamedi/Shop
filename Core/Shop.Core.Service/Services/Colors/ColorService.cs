using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Colors
{
    public class ColorService : IColorService
    {
        private readonly IColorRepository colorRepository;
        private readonly IMapper mapper;
        private readonly IProductColorRepository productColorRepository;

        public ColorService(IColorRepository colorRepository,IMapper mapper,IProductColorRepository productColorRepository)
        {
            this.colorRepository = colorRepository;
            this.mapper = mapper;
            this.productColorRepository = productColorRepository;
        }

        public void AddColor(ColorDto colorDto)
        {
            var color = mapper.Map<Domain.Entities.Color>(colorDto);
            colorRepository.AddColor(color);

        }

        public ShopActionResult<List<ColorDto>> GetAllColor(int page = 1)
        {
            ShopActionResult<List<ColorDto>> actionResult = new ShopActionResult<List<ColorDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 3;
            var skip = (page - 1) * actionResult.ItemCount;
            var colorlist = colorRepository.GetAll();
            actionResult.Counts = colorlist.Count();
            var AllCount = colorlist.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<ColorDto> colorDtos = new List<ColorDto>();

            foreach (var item in AllCount)
            {
                var listColor = mapper.Map<ColorDto>(item);
                colorDtos.Add(listColor);

            }
            actionResult.Data = colorDtos;
            return actionResult;
        }

        public List<ColorDto> GetAllColor()
        {
            List<ColorDto> colorDtos = new List<ColorDto>();
            var colorlist = colorRepository.GetAll();
            foreach (var item in colorlist)
            {
                var color = mapper.Map<ColorDto>(item);
                colorDtos.Add(color);
            }
            return colorDtos;
        }

        public ColorDto GetByColorId(int colorid)
        {
            var color = colorRepository.GetByColorId(colorid);
            var Color = mapper.Map<ColorDto>(color);
            return Color;
        }

        public List<ColorDto> GetByProductColor(int productid)
        {
            var ColorPro = productColorRepository.AllColorProId(productid);
            List<ColorDto> colorDtos = new List<ColorDto>();
            foreach (var item in ColorPro)
            {
                var color = colorRepository.GetByColorId(item.ColorId);
                var Color = mapper.Map<ColorDto>(color);
                colorDtos.Add(Color);
            }
            return colorDtos;
        }

        public List<ColorProductDto> GetByProductId(int productid)
        {
            var ColorPro = productColorRepository.AllColorProId(productid);
            List<ColorProductDto> colorDtos = new List<ColorProductDto>();
            foreach (var item in ColorPro)
            {
                var colorProduct = productColorRepository.GetColorByProductId(item.ColorId, productid);
                var color = colorRepository.GetByColorId(item.ColorId);
                ColorProductDto colorDto = new ColorProductDto();
                colorDto.ColorCode = color.ColorCode;
                colorDto.ColorId = color.ColorId;
                colorDto.ColorPro = color.ColorPro;
                colorDto.ProductId = productid;
                colorDto.ProductColorId = colorProduct.ProductColorId;
                colorDtos.Add(colorDto);
            }
            return colorDtos;
        }

        public void UpdateColor(ColorDto colorDto)
        {
            var color = mapper.Map<Domain.Entities.Color>(colorDto);
            colorRepository.UpdateColor(color);
        }
    }
}

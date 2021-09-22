using Shop.Common;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Colors
{
    public interface IColorService
    {
        List<ColorProductDto> GetByProductId(int productid);
        List<ColorDto> GetByProductColor(int productid);
        ColorDto GetByColorId(int colorid);
        void AddColor(ColorDto colorDto);
        void UpdateColor(ColorDto colorDto);
        ShopActionResult<List<ColorDto>> GetAllColor(int page = 1);
        List<ColorDto> GetAllColor();
    }
}

using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Index
{
    public interface IProductIndexService 
    {
        IEnumerable<InexpensiveProIndexDto> InexpensiveProduct();
        IEnumerable<NewProductDto> NewProduct();
        IEnumerable<MostdiscountsDto> Mostdiscounts();
        IEnumerable<BestsellingDto> Bestselling();
    }
}

using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Weights
{
    public interface IWeightService
    {
        decimal SendPrice(string username);
        void UpdateWeight(WeightDto weightDto);
        void AddWeight(WeightDto weightDto);
        WeightDto GetById(int id);
        ShopActionResult<List<WeightDto>> GetAllWeight(int page = 1);
        void RemoveWeight(WeightDto weightDto);
    }
}

using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Weights
{
    public class WeightService : IWeightService
    {
        private readonly IUserRepositroy userRepositroy;
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly IWeightRepository weightRepository;
        private readonly IMapper mapper;

        public WeightService(IUserRepositroy userRepositroy,IShoppingCartRepository
            shoppingCartRepository,IProductRepository productRepository,
            IWeightRepository weightRepository,IMapper mapper)
        {
            this.userRepositroy = userRepositroy;
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.weightRepository = weightRepository;
            this.mapper = mapper;
        }

        public void AddWeight(WeightDto weightDto)
        {
            var weight = mapper.Map<Weight>(weightDto);
            weightRepository.AddWeight(weight);
        }

        public ShopActionResult<List<WeightDto>> GetAllWeight(int page = 1)
        {
            ShopActionResult<List<WeightDto>> actionResult = new ShopActionResult<List<WeightDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 4;
            var skip = (page - 1) * actionResult.ItemCount;
            var ListWeight = weightRepository.GetAll();
            actionResult.Counts = ListWeight.Count();
            var AllCount = ListWeight.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<WeightDto> weightDtos = new List<WeightDto>();

            foreach (var item in AllCount)
            {
                var ListArticleDto = mapper.Map<WeightDto>(item);
                weightDtos.Add(ListArticleDto);

            }
            actionResult.Data = weightDtos;
            return actionResult;
        }

        public WeightDto GetById(int id)
        {
            var weight = weightRepository.GetById(id);
            var Weight = mapper.Map<WeightDto>(weight);
            return Weight;
        }

        public void RemoveWeight(WeightDto weightDto)
        {
            var weight = mapper.Map<Weight>(weightDto);
            weightRepository.RemoveWeight(weight);
        }

        public decimal SendPrice(string username)
        {
            var user = userRepositroy.GetByUserName(username);
            var listshopping = shoppingCartRepository.GetAllUserById(user.Id);

            List<int> sumweight = new List<int>();
            foreach (var item in listshopping)
            {
                var product = productRepository.GetProductById(item.ProductId);
                sumweight.Add(product.Weight * item.Count);

            }
            var weightSum = sumweight.Sum();

            var sendprice = weightRepository.GetWeight_Price(weightSum, weightSum);
            return sendprice;
        }

        public void UpdateWeight(WeightDto weightDto)
        {
            var weight = mapper.Map<Weight>(weightDto);
            weightRepository.UpdateWeight(weight);
        }
    }
}

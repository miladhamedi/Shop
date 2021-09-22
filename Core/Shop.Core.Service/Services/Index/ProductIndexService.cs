using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Index
{
    public class ProductIndexService : IProductIndexService
    {
        private readonly IProductIndexRepository productIndexRepository;
        private readonly IMapper mapper;
        private readonly IColorRepository colorRepository;

        public ProductIndexService(IProductIndexRepository
            productIndexRepository, IMapper mapper, IColorRepository colorRepository)
        {
            this.productIndexRepository = productIndexRepository;
            this.mapper = mapper;
            this.colorRepository = colorRepository;
        }

        public IEnumerable<BestsellingDto> Bestselling()
        {
            var BestProList = productIndexRepository.Bestselling();
            List<BestsellingDto> bestsellingDtos = new List<BestsellingDto>();
            foreach (var item in BestProList)
            {
                var BestProlist = mapper.Map<BestsellingDto>(item);
                bestsellingDtos.Add(BestProlist);
            }
            return bestsellingDtos.Take(10);
        }

        public IEnumerable<InexpensiveProIndexDto> InexpensiveProduct()
        {
            var listPro = productIndexRepository.InexpensiveProduct();

            List<InexpensiveProIndexDto> inexpensiveProIndexDtos = new List<InexpensiveProIndexDto>();
            foreach (var item in listPro)
            {
                var Listprodct = mapper.Map<InexpensiveProIndexDto>(item);
                inexpensiveProIndexDtos.Add(Listprodct);
            }
            return inexpensiveProIndexDtos.Take(5);
        }

        public IEnumerable<MostdiscountsDto> Mostdiscounts()
        {

            var listPro = productIndexRepository.Mostdiscounts();
            List<MostdiscountsDto> mostdiscountsDtos = new List<MostdiscountsDto>();
            foreach (var item in listPro)
            {
                MostdiscountsDto MostdiscountsDto = new MostdiscountsDto();
                MostdiscountsDto.Color = colorRepository.GetByColorId(item.ProductColors.First().ColorId).ColorPro;
                MostdiscountsDto.Title = item.Titel;
                MostdiscountsDto.Warranty = item.TechnicalDetails.First().Warranty;
                MostdiscountsDto.Picture = item.Galleries.First().PictureName;
                MostdiscountsDto.Manufacturer = item.TechnicalDetails.First().Manufacturer;
                MostdiscountsDto.Description = item.Description;
                MostdiscountsDto.ProductId = item.ProductId;
                mostdiscountsDtos.Add(MostdiscountsDto);
            }
            return mostdiscountsDtos.Take(3);
        }

        public IEnumerable<NewProductDto> NewProduct()
        {
            var listproNew = productIndexRepository.NewProduct();
            List<NewProductDto> newProductDtos = new List<NewProductDto>();
            foreach (var item in listproNew)
            {
                var ListprodctNew = mapper.Map<NewProductDto>(item);
                newProductDtos.Add(ListprodctNew);
            }
            return newProductDtos.Take(10);
        }
    }
}

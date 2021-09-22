using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.TechnicalDetails
{
    public class TechnicalDetailService : ITechnicalDetailService
    {
        private readonly ITechnicalDetailRepository technicalDetailRepository;
        private readonly IMapper mapper;

        public TechnicalDetailService(ITechnicalDetailRepository technicalDetailRepository,IMapper mapper)
        {
            this.technicalDetailRepository = technicalDetailRepository;
            this.mapper = mapper;
        }

        public int AddTechnicalDetail(TechnicalDetailDto technicalDetail)
        {
            var technicalDe = mapper.Map<TechnicalDetail>(technicalDetail);
            technicalDetailRepository.AddTechnicalDetail(technicalDe);
            return technicalDe.ProductId;
        }

        public TechnicalDetailDto GetByProductId(int productid)
        {
            var TechnicalDetail = technicalDetailRepository.GetByProductId(productid);
            var technicalDetail = mapper.Map<TechnicalDetailDto>(TechnicalDetail);
            return technicalDetail;
        }

        public void UpdateTechnicalDetail(TechnicalDetailDto technicalDetail)
        {
            var technicalDe = mapper.Map<TechnicalDetail>(technicalDetail);
            technicalDetailRepository.UpdateTechnicalDetail(technicalDe);
        }
    }
}

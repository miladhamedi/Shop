using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.TechnicalDetails
{
    public interface ITechnicalDetailService
    {
        TechnicalDetailDto GetByProductId(int productid);
        int AddTechnicalDetail(TechnicalDetailDto technicalDetail);
        void UpdateTechnicalDetail(TechnicalDetailDto technicalDetail);

    }
}

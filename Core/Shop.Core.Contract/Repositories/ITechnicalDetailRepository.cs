using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface ITechnicalDetailRepository
    {

        TechnicalDetail GetByProductId(int productid);
        int AddTechnicalDetail(TechnicalDetail technicalDetail);
        void UpdateTechnicalDetail(TechnicalDetail technicalDetail);
    }
}

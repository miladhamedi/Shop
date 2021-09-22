using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IinvoiceRepository
    {
        List<Invoice> GetInvoiceByUserId(Guid userid);
        Invoice GetInvoiceUserId(Guid userid);
        List<Invoice> GetAllInvoice();
        Invoice GetInvUserId(Guid userid,int invoice);
        Invoice InvoiceRefById(Guid userid, string Authority);
        void UpdateInvoice(Invoice invoice);
        void AddInvoice(Invoice invoice);
        Invoice GetByIdInvoice(Guid userid, int invoice);
        Invoice GetbyUseridInvoice(Guid userid, int invoice);
        List<Invoice> GetLastInvoice();
        List<Invoice> GetAll();
        
       

    }
}

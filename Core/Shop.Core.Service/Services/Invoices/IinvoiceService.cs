using Shop.Common;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Invoices
{
    public interface IinvoiceService
    {
        ShopActionResult<List<InvoiceDto>> GetOrderProfile(string username, int page = 1);
        InvoiceDto GetInvoiceById(Guid userid);
        void UpdateInvoice(InvoiceDto invoiceDto);
        void AddInvoice(InvoiceDto invoiceDto);
        InvoiceDto GetInvUserId(Guid userid, int invoice);
        InvoiceDto InvoiceRefById(Guid userid, string invoice);
        InvoiceDto GetByIdInvoice(Guid userid, int invoice);
        ShopActionResult<List<InvoiceDto>> GetAll(int page = 1);
        ShopActionResult<List<InvoiceDto>> GetAllInvoice(int page = 1);
        InvoiceDto GetbyUseridInvoice(Guid userid, int invoice);
        InvoiceDto GetStatusProcess(Guid userid, int invoicenumber);





    }
}

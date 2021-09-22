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

namespace Shop.Core.Service.Services.Invoices
{
    public class InvoiceService : IinvoiceService
    {
        private readonly IinvoiceRepository iinvoiceRepository;
        private readonly IUserRepositroy userRepositroy;
        private readonly IMapper mapper;

        public InvoiceService(IinvoiceRepository iinvoiceRepository, IUserRepositroy userRepositroy, IMapper mapper)
        {
            this.iinvoiceRepository = iinvoiceRepository;
            this.userRepositroy = userRepositroy;
            this.mapper = mapper;
        }
        public ShopActionResult<List<InvoiceDto>> GetOrderProfile(string username, int page = 1)
        {
            ShopActionResult<List<InvoiceDto>> shopActionResult = new ShopActionResult<List<InvoiceDto>>();
            var UserId = userRepositroy.GetByUserName(username);
            var GetOrder = iinvoiceRepository.GetInvoiceByUserId(UserId.Id);
            if (GetOrder == null)
                return null;
            shopActionResult.Page = page;
            shopActionResult.Counts = GetOrder.Count();
            shopActionResult.ItemCount = 5;
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            var skip = (page - 1) * shopActionResult.ItemCount;
            var AllOrder = GetOrder.Skip(skip).Take(shopActionResult.ItemCount);
            List<InvoiceDto> invoiceDtos = new List<InvoiceDto>();
            foreach (var item in AllOrder)
            {
                var GetListOrder = mapper.Map<InvoiceDto>(item);

                invoiceDtos.Add(GetListOrder);
            }
            shopActionResult.Data = invoiceDtos;
            return shopActionResult;
        }

        public InvoiceDto GetInvoiceById(Guid userid)
        {
            var invoice = iinvoiceRepository.GetInvoiceUserId(userid);
            var GetListOrder = mapper.Map<InvoiceDto>(invoice);
            return GetListOrder;
        }

        public void UpdateInvoice(InvoiceDto invoiceDto)
        {
            var invoice = mapper.Map<Invoice>(invoiceDto);
            iinvoiceRepository.UpdateInvoice(invoice);
        }

        public void AddInvoice(InvoiceDto invoiceDto)
        {
            var invoice = mapper.Map<Invoice>(invoiceDto);
            iinvoiceRepository.AddInvoice(invoice);
        }

        public InvoiceDto GetInvUserId(Guid userid, int invoice)
        {

            var qinvoice = iinvoiceRepository.GetInvUserId(userid, invoice);
            var invoices = mapper.Map<InvoiceDto>(qinvoice);
            return invoices;
        }

        public InvoiceDto InvoiceRefById(Guid userid, string Authority)
        {
            var qinvoice = iinvoiceRepository.InvoiceRefById(userid, Authority);
            var invoices = mapper.Map<InvoiceDto>(qinvoice);
            return invoices;
        }

        public InvoiceDto GetByIdInvoice(Guid userid, int invoice)
        {
            var Invoice = iinvoiceRepository.GetByIdInvoice(userid, invoice);
            var invoices = mapper.Map<InvoiceDto>(Invoice);
            return invoices;
        }

        public ShopActionResult<List<InvoiceDto>> GetAll(int page = 1)
        {
            ShopActionResult<List<InvoiceDto>> shopActionResult = new ShopActionResult<List<InvoiceDto>>();
            var ListInvoice = iinvoiceRepository.GetAll();
            shopActionResult.Page = page;
            shopActionResult.Counts = ListInvoice.Count();
            shopActionResult.ItemCount = 5;
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            var skip = (page - 1) * shopActionResult.ItemCount;
            var listinoice = ListInvoice.Skip(skip).Take(shopActionResult.ItemCount);
            List<InvoiceDto> invoiceDtos = new List<InvoiceDto>();
            foreach (var item in listinoice)
            {
                var invoice = mapper.Map<InvoiceDto>(item);
                invoiceDtos.Add(invoice);
            }
            shopActionResult.Data = invoiceDtos;
            return shopActionResult;
        }

        public ShopActionResult<List<InvoiceDto>> GetAllInvoice(int page = 1)
        {
            ShopActionResult<List<InvoiceDto>> shopActionResult = new ShopActionResult<List<InvoiceDto>>();
            var ListInvoice = iinvoiceRepository.GetAllInvoice();
            shopActionResult.Page = page;
            shopActionResult.Counts = ListInvoice.Count();
            shopActionResult.ItemCount = 5;
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            var skip = (page - 1) * shopActionResult.ItemCount;
            var listinoice = ListInvoice.Skip(skip).Take(shopActionResult.ItemCount);
            List<InvoiceDto> invoiceDtos = new List<InvoiceDto>();
            foreach (var item in listinoice)
            {
                var invoice = mapper.Map<InvoiceDto>(item);
                invoiceDtos.Add(invoice);
            }
            shopActionResult.Data = invoiceDtos;
            return shopActionResult;
        }

        public InvoiceDto GetbyUseridInvoice(Guid userid, int invoice)
        {
            var Invoice = iinvoiceRepository.GetbyUseridInvoice(userid, invoice);
            var invoices = mapper.Map<InvoiceDto>(Invoice);
            return invoices;
        }


    }
}

using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class InvoiceRepository : IinvoiceRepository
    {
        private readonly ShopDbContext shopDbContext;

        public InvoiceRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddInvoice(Invoice invoice)
        {
            shopDbContext.Invoices.Add(invoice);
            shopDbContext.SaveChanges();
        }

        
        public List<Invoice> GetAll()
        {
            var Listinvoice = shopDbContext.Invoices.OrderByDescending(c=>c.Date >= DateTime.Now.AddDays(-7)).AsNoTracking().ToList();
            return Listinvoice;
        }

        public List<Invoice> GetAllInvoice()
        {
            var listInvoice = shopDbContext.Invoices.Where(c => c.Status == true).OrderByDescending(c => c.Date).AsNoTracking().ToList();
            return listInvoice;
        }

        public Invoice GetByIdInvoice(Guid userid, int invoice)
        {
            var invoices = shopDbContext.Invoices.Where(c => c.UserId == userid && c.InvoiceId == invoice && c.Status == true).SingleOrDefault();
            return invoices;
        }

        public Invoice GetbyUseridInvoice(Guid userid, int invoice)
        {
            var qinvoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.InvoiceNumber == invoice && c.Status == false).FirstOrDefault();
            return qinvoice;
        }

        public List<Invoice> GetInvoiceByUserId(Guid userid)
        {
            var invoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.Status == true).OrderByDescending(c=>c.Date).AsNoTracking().ToList();
            return invoice;
        }

        public Invoice GetInvoiceUserId(Guid userid)
        {
          var invoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.Status == false && c.InvoiceNumber > 0 && c.RefrenceId == null).FirstOrDefault();
            return invoice;
        }

        public Invoice GetInvUserId(Guid userid, int invoice)
        {
            var qinvoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.InvoiceNumber == invoice && c.Status == false).FirstOrDefault();
            return qinvoice;
        }

        public List<Invoice> GetLastInvoice()
        {
            var Lastproduct = shopDbContext.Invoices.OrderByDescending(c => c.Date).Take(6).AsNoTracking().ToList();
            return Lastproduct;
        }

        public Invoice GetStatusProcess(Guid userid, int invoicenumber)
        {
            var invoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.InvoiceNumber == invoicenumber && c.Status == true).AsNoTracking().FirstOrDefault();
            return invoice;
        }

        public Invoice InvoiceRefById(Guid userid, string Authority)
        {
            var qinvoice = shopDbContext.Invoices.Where(c => c.UserId == userid && c.RefrenceId == Authority && c.Status == false).FirstOrDefault();
            return qinvoice;
        }

        

        public void UpdateInvoice(Invoice invoice)
        {
            shopDbContext.Invoices.Attach(invoice);
            shopDbContext.Entry(invoice).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}

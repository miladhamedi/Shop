using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Shop.Core.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [MaxLength(100)]
        public string NameFamily { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(100)]
        public string Province { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(10)]
        public string IrCode { get; set; }
        public DateTime Date { get; set; }
        public bool Access { get; set; }
        public string ActiveCode { get; set; }

        public List<Invoice> Invoices { get; set; }
        public List<ShoppingCart> ShoppingCarts { get; set; }
        public List<Comment> Comments { get; set; }
       


    }
}

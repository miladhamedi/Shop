using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class UserDto : IdentityUser<Guid>
    {

        public string NameFamily { get; set; }

        public string City { get; set; }

  
        public string Province { get; set; }

       
        public string Address { get; set; }

      
        public string PostalCode { get; set; }
     
        public string IrCode { get; set; }
        public DateTime Date { get; set; }
        public bool Access { get; set; }
        public string ActiveCode { get; set; }




    }
}

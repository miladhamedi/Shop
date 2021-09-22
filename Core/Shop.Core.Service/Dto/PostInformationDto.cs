using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class PostInformationDto
    {
        public string NameFamily { get; set; }

        public string IrCode { get; set; }

        public string City { get; set; }


        public string Province { get; set; }


        public string Address { get; set; }


        public string PostalCode { get; set; }
        public DateTime Date { get; set; }

        public string PnoneNumber { get; set; }
    }
}

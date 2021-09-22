using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class InexpensiveProIndexDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
       


    }
}

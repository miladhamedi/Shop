using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class UserPageDto
    {
        public int UserPageId { get; set; }
       
        public Guid RoleId { get; set; }
      

        public string PageNameEn { get; set; }
       

        public string PageNameFa { get; set; }

       
        public string ControllerName { get; set; }
    }
}

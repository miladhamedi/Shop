using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class SettingDto
    {
        public int SettingId { get; set; }

   
        public string Titel { get; set; }

        
        public string Description { get; set; }

    
        public int PageNumber { get; set; }

        public string Smtp { get; set; }

       
        public string Email { get; set; }

     
        public string PassWordEmail { get; set; }

      
        public string SmsService { get; set; }

      
        public string SmsUser { get; set; }

      
        public string SmsPassword { get; set; }
    }
}

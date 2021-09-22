using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class ArticleDto
    {
        public int ArticleId { get; set; }

       
        public string Titel { get; set; }

       
        public string Description { get; set; }

       
        public string Text { get; set; }

        
        public string Image { get; set; }


        public int View { get; set; }

        
        public DateTime Date { get; set; }
    }
}

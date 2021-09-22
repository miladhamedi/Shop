using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        [Display(Name = "عنوان دسته")]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(30, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]

        public string Titel { get; set; }

        [Display(Name = "فعال/ غیر فعال")]
        public bool ActivePassive { get; set; }
        
    }
}

using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class GalleryViewModel
    {
        public int GalleryId { get; set; }

        [Display(Name = "عنوان تصویر ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MinLength(3, ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Titel { get; set; }

        [Display(Name = "  نام تصویر ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string PictureName { get; set; }

        [Display(Name = "  تصویر شاخص ")]
        public bool Default { get; set; }

        public int ProductId { get; set; }
    }
}

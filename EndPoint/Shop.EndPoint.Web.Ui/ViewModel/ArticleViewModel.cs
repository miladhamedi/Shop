using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class ArticleViewModel
    {
        public int ArticleId { get; set; }

        [Display(Name = "عنوان مقاله")]
        [MaxLength(150, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Titel { get; set; }

        [Display(Name = "توضیح مختصر ")]
        [MaxLength(250, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Description { get; set; }

        [Display(Name = " متن مقاله ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Text { get; set; }

        [Display(Name = " تصویر مقاله ")]
        public string Image { get; set; }


        [Display(Name = " تعداد بازدید")]
        [Required]
        public int View { get; set; }

        [Display(Name = "زمان ثبت")]
        [Required]
        public DateTime Date { get; set; }
    }
}

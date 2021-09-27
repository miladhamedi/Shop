using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class EditProductViewModel
    {
        public int ProductId { get; set; }
        [Display(Name = "غیر فعالسازی/فعال ")]
        public bool ActiveInActive { get; set; }
        [Display(Name = "عنوان محصول ")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        //[MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        //[MinLength(3, ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        //[RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Titel { get; set; }
        [Display(Name = "قیمت محصول ")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public decimal Price { get; set; }
        [Display(Name = " درصد تخفیف ")]
        public decimal DiscuntPercent { get; set; }
        [Display(Name = "موجودی")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public int Stcok { get; set; }
        [Display(Name = "توضیحات")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        //[RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Description { get; set; }
        [Display(Name = "وزن محصول")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public int Weight { get; set; }
        [Display(Name = "قیمت با تخفیف ")]
        //[Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public decimal DiscuntedPrice { get; set; }
        [Display(Name = "دسته بندی محصول")]
        public int CategoryId { get; set; }
    }
}

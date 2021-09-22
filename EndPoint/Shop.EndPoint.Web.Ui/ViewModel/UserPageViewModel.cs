using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class UserPageViewModel
    {
        public int UserPageId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public Guid RoleId { get; set; }
        [Display(Name = "نام انگلیسی صفحه")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]

        public string PageNameEn { get; set; }
        [Display(Name = "نام فارسی صفحه")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]

        public string PageNameFa { get; set; }

        [Display(Name = "نام  کنترل صفحه")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string ControllerName { get; set; }
    }
}

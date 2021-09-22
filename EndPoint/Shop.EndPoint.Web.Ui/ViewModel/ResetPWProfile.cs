using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class ResetPWProfile
    {
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [DataType(DataType.Password)]
        [Display(Name = "رمز قدیمی")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100,  ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز جدید")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز جدید")]
        [Compare("NewPassword", ErrorMessageResourceName = nameof(MessageRes.Compare), ErrorMessageResourceType = typeof(MessageRes))]
        public string ConfirmPassword { get; set; }
    }
}

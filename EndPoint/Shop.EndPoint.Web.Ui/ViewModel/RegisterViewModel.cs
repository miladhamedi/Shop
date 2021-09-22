using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class RegisterViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [EmailAddress(ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Email { get; set; }


        [Display(Name = "نام و نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [DataType(DataType.Text)]
        public string NameFamily { get; set; }

        [Display(Name = "شماره همراه")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [StringLength(11, ErrorMessage = "حتما 11 شماره باید باشد", MinimumLength = 11)]
        [DataType(DataType.PhoneNumber)]

        public string PhoneNumber { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [StringLength(20, ErrorMessage = "باید بیشتر از {2} و کمتر از {1} باشد {0}", MinimumLength = 6)]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessageResourceName = nameof(MessageRes.Compare), ErrorMessageResourceType = typeof(MessageRes))]
        public string ConfirmPassword { get; set; }
    }
}

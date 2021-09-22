using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Setting
    {
        public int SettingId { get; set; }

        [Display(Name = "عنوان سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(75, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Titel { get; set; }

        [Display(Name = "توضیح سایت")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(150, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Description { get; set; }

        [Display(Name = "تعداد در صفحه  ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public int PageNumber { get; set; }

        [Display(Name = " Smtp")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Smtp { get; set; }

        [Display(Name = "ایمیل ")]
        [RegularExpression(@"[\w_\-\.]+[@][\w_\-\.]+[\.][\w]{2,7}", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Email { get; set; }

        [Display(Name = " کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string PassWordEmail { get; set; }

        [Display(Name = " شماره پیامک ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string SmsService { get; set; }

        [Display(Name = " نام کاربری پیامک ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string SmsUser { get; set; }

        [Display(Name = " کلمه عبور پیامک")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string SmsPassword { get; set; }




    }
}

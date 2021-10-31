using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class MessageViewModel
    {

        [Display(Name = "پیام")]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(1000, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Text { get; set; }
        public string UserNameSend { get; set; }
        [Display(Name = "گیرنده")]
        public Guid UserIdRecive { get; set; }
        [Display(Name = "فرستنده")]
        public Guid UserIdSend { get; set; }

        [Display(Name = "تایید/عدم تایید")]
        public bool Confirm { get; set; }
        [Display(Name = "تاریخ")]
        public DateTime Date { get; set; }
       
        public int MessageId { get; set; }

    }
}

using System;
using Shop.Core.Domain.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [Display(Name = "فرستنده")]
        public Guid UserIdSend { get; set; }
        [Required]
        [Display(Name = "گیرنده")]
        public Guid UserIdRecive { get; set; }

        [Display(Name = "پیام")]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(1000, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]

        public string Text { get; set; }

        [Display(Name = " ژمان ثبت")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public DateTime Date { get; set; }

        [Display(Name ="تایید/رد ")]
        public bool Confirm { get; set; }


       
    }
}

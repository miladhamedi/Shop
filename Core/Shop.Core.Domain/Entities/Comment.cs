using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MinLength(3, ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string NameFamily { get; set; }

        [Display(Name = "ایمیل")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(150, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [RegularExpression(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$", ErrorMessageResourceName = nameof(MessageRes.RegeMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Email { get; set; }

        [Display(Name = "متن نظر")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(1000, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MinLength(3, ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Text { get; set; }

        [Display(Name = "آی پی فرستنده")]
        public string IP { get; set; }

        [Display(Name = "تاریخ ثبت ")]
        public DateTime Date { get; set; }
        [Display(Name = "تایید نظر")]
        public bool Confirm { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}

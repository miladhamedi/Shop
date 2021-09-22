using Shop.Core.Domain.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "کد محصول ")]
        [MaxLength(20)]
        [Required]
        public string CodeProduct { get; set; }

        [Display(Name = "عنوان محصول ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(100, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MinLength(3, ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Titel { get; set; }
        [Display(Name = "تعداد بازدید محصول ")]
        public int Visit { get; set; }

        [Display(Name = "قیمت محصول ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(12, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public decimal Price { get; set; }
        [Display(Name = " درصد تخفیف ")]
        public decimal DiscuntPercent { get; set; }
        [Display(Name = "قیمت با تخفیف ")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [MaxLength(12, ErrorMessageResourceName = nameof(MessageRes.MaxLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public decimal DiscuntedPrice { get; set; }
        [Display(Name = "غیر فعالسازی/فعال ")]
        public bool ActiveInActive { get; set; }
        [Display(Name = "زمان ثبت")]
        public DateTime Date { get; set; }
        [Display(Name = "موجودی")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public int Stcok { get; set; }

        [Display(Name = "توضیحات")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        [RegularExpression(@"[a-zا-یA-Z0-9آ\s_\-]*", ErrorMessageResourceName = nameof(MessageRes.MinLenghtMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public string Description { get; set; }
        [Display(Name = "وزن محصول")]
        [Required(AllowEmptyStrings = false, ErrorMessageResourceName = nameof(MessageRes.RequierdMsg), ErrorMessageResourceType = typeof(MessageRes))]
        public int Weight { get; set; }

        public Guid IdUser { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public List<ProductColor> ProductColors { get; set; }
        public List<Comment> Comments { get; set; }

        public List<ShoppingCart> ShoppingCarts { get; set; }

        public List<TechnicalDetail> TechnicalDetails { get; set; }

        public List<Gallery> Galleries { get; set; }
       
        public List<Invoice> Invoices { get; set; }


    }
}

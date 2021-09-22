using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }
        [Display(Name = " کد محصول")]
        [Required]
        public string ProductCode { get; set; }
        [Display(Name = " تاریخ خرید")]
        [Required]
        public DateTime Date { get; set; }
        [Display(Name = " وضعیت")]
        [Required]
        public bool Status { get; set; }
        [Display(Name = " تعداد")]
        [Required]
        public int Count { get; set; }
        [Display(Name = " مبلغ پرداختی")]
        [Required]
        [MaxLength(15)]
        public decimal  Price { get; set; }
        [Display(Name = " هزینه پست")]
        [Required]
        [MaxLength(15)]
        public decimal  AmountSent { get; set; }
        [Display(Name = " مالیات")]
        [Required]
        [MaxLength(15)]
        public decimal  Tax { get; set; }
      
        [Display(Name = " شناسه سفارش")]
        [Required]
        public int InvoiceNumber { get; set; }

        [Display(Name = " گارانتی انتخابی")]
        [Required]
        [MaxLength(100)]
        public string Warranty { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ProductId { get; set; }
        public Product  Product { get; set; }
    }
}

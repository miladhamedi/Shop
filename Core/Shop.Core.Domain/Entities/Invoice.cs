using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        [Display(Name = " تاریخ خرید")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = " وضعیت")]
        public bool Status { get; set; }
        [Required]
        [Display(Name = " تعداد")]
        public int Count { get; set; }
        [Required]
        [Display(Name = " شناسه سفارش")]
        public int InvoiceNumber { get; set; }
        [Display(Name = " مبلغ پرداختی")]
        [Required]
        public decimal Price { get; set; }
        [Display(Name = " هزینه پست")]
        [Required]
        [MaxLength(15)]
        public decimal  AmountSent { get; set; }
        [Display(Name = " مالیات")]
        [Required]
        [MaxLength(15)]
        public decimal  Tax { get; set; }
        [Display(Name = " شناسه تراکنش")]
        [MaxLength(100)]
        public string TransactionId { get; set; }
        [Display(Name = " شناسه مرجع")]
        [MaxLength(100)]
        public string RefrenceId { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

       
    } 
}

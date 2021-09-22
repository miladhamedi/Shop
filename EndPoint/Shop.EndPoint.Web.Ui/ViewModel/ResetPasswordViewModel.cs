using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class ResetPasswordViewModel
    {
       
        public Guid UserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "پسورد باید بین 6 تا 20 کاراکنر باشد", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "رمز عبور و رمز تأیید مطابقت ندارند.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}

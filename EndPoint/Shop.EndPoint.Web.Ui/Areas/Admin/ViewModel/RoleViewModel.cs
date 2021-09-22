using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.ViewModel
{
    public class RoleViewModel
    {
        public Guid RoleId { get; set; }
        [Display(Name = "نقش کاربر")]
        [Required()]
        public string RoleName { get; set; }
    }
}

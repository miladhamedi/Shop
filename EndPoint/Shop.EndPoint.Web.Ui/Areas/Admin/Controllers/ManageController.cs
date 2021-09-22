using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    
    public class ManageController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

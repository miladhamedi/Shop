﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class TechnicalDetailViewModel
    {
        public int TechnicalDetailId { get; set; }
        [Display(Name = "جنس محصول")]
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }
        [Display(Name = "شرکت سازنده ")]
        [MaxLength(100)]
        public string Manufacturer { get; set; }
        [Display(Name = "کشور سازنده ")]
        [MaxLength(100)]
        public string ManufacturingCountry { get; set; }
        [Display(Name = " مدل ")]
        [MaxLength(100)]
        public string Model { get; set; }
        [Display(Name = "سال تولید")]
        [MaxLength(100)]
        public string ProductionYear { get; set; }
        [Display(Name = "گارانتی ")]
        [MaxLength(100)]
        public string Warranty { get; set; }


        public int ProductId { get; set; }
    }
}

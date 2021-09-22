using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Core.Domain.Entities
{
    public class Weight
    {
        public int WeightId { get; set; }
        [Display(Name = " حداکثر وزن ")]
        public int Weight_Max { get; set; }
        [Display(Name = " حداقل وزن ")]
        public int Weight_Min { get; set; }
        [Display(Name = "  هزینه ")]
        public decimal Weight_Price { get; set; }
    }
}

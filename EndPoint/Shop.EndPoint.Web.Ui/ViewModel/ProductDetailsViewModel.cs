using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.ViewModel
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal PriceDisCount { get; set; }
        public int View { get; set; }
        public DateTime Date { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturingCountry { get; set; }
        public string Model { get; set; }
        public string ProductionYear { get; set; }
        public string Warranty { get; set; }
        public decimal DiscountPercent { get; set; }

        public List<ColorDto> ColorDtos { get; set; }
        public List<CommentDto> CommentDtos { get; set; }
        public List<GalleryDto> GalleryDtos { get; set; }
    }
}

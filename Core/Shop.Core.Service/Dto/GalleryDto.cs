using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class GalleryDto
    {
        public int GalleryId { get; set; }
        public string Titel { get; set; }
        public string PictureName { get; set; }
        public bool Default { get; set; }
        public int ProductId { get; set; }
    }
}

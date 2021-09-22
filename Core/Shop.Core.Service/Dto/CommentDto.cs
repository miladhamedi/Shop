using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string NameFamily { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public string IP { get; set; }
        public DateTime Date { get; set; }
        public bool Confirm { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }



    }
}

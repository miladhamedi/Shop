using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Dto.IndexDto
{
    public class MessageDto
    {
        public int MessageId { get; set; }
        public Guid UserIdSend { get; set; }
        public Guid UserIdRecive { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool Confirm { get; set; }

    }
}

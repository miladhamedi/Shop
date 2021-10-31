using Kavenegar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.ServiceSender
{
    public class SmsSender
    {
        public void SMS(string to, string body)
        {
            var sender = "100047778";
            var receptor = to;
            var message = body;
            var api = new KavenegarApi("76616D4762434E6666434C677752784D4876514D4B6F6673513132324F6B4975416D4C48343136467448453D");

            api.Send(sender, receptor, message);

        }
    }
}

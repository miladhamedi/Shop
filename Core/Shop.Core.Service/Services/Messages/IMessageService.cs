using Shop.Common;
using Shop.Core.Service.Dto.IndexDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Messages
{
    public interface IMessageService
    {
        void AddMessage(MessageDto message);
        ShopActionResult<List<MessageDto>> GetUserMessageAll(Guid userid,int page = 1);
        ShopActionResult<List<MessageDto>> GetAdminMessageRecive(Guid userid, int page = 1);
        ShopActionResult<List<MessageDto>> GetAllMessageAdmin( int page = 1);
        void UpdateMessage(MessageDto messageDto);
        MessageDto GetById(int messageid);

    }
}

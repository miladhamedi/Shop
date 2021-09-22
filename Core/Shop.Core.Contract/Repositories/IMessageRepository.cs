using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void UpdateMessage(Message message);
        List<Message> GetAdminMessageRecive(Guid userid);
        List<Message> GetUserMessageAll(Guid userid);
        List<Message> GetMessageAdmin(Guid userid);
        List<Message> GetAll();
        Message GetById(int messageid);
       
    }
}

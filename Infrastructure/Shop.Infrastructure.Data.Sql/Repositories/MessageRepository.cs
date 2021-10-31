using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ShopDbContext shopDbContext;


        public MessageRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;

        }

        public List<Message> GetUserMessageAll(Guid userid)
        {
            var userList = shopDbContext.Messages.Where(c => c.UserIdSend == userid).OrderByDescending(c=>c.Date).AsNoTracking().ToList();
            return userList;
        }


        public void AddMessage(Message message)
        {
            shopDbContext.Messages.Add(message);
            shopDbContext.SaveChanges();
        }

        public List<Message> GetAdminMessageRecive(Guid userid)
        {
            var MessageList = shopDbContext.Messages.Where(c => c.UserIdRecive == userid).OrderByDescending(c=>c.Date).AsNoTracking().ToList();
            return MessageList;
        }

        public List<Message> GetMessageAdmin(Guid userid)
        {
            var message = shopDbContext.Messages.Where(c => c.Confirm == false && c.UserIdRecive == userid).ToList();
            return message;
        }

        public List<Message> GetAll()
        {
            var listmessage = shopDbContext.Messages.ToList();
            return listmessage;
        }

        public Message GetById(int messageid)
        {
            var message = shopDbContext.Messages.Where(c => c.MessageId == messageid).AsNoTracking().FirstOrDefault();
            return message;
        }

        public void UpdateMessage(Message message)
        {
            shopDbContext.Messages.Attach(message);
            shopDbContext.Entry(message).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}

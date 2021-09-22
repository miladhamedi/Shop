using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto.IndexDto;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Common;

namespace Shop.Core.Service.Services.Messages
{
    public class MessageService :IMessageService
    {
        private readonly IMessageRepository messageRepository;
        private readonly IMapper mapper;
        private readonly IRoleRepository roleRepository;
        private readonly IUserRoleRepository userRoleRepository;

        public MessageService(IMessageRepository messageRepository,
            IMapper mapper,IRoleRepository roleRepository,IUserRoleRepository userRoleRepository)
        {
            this.messageRepository = messageRepository;
            this.mapper = mapper;
            this.roleRepository = roleRepository;
            this.userRoleRepository = userRoleRepository;
        }

       

        public void AddMessage(MessageDto message)
        {
            var UserMessage = mapper.Map<Message>(message);
            messageRepository.AddMessage(UserMessage);
        }

        public ShopActionResult<List<MessageDto>> GetAdminMessageRecive(Guid userid, int page = 1)
        {
            List<MessageDto> messageDtos = new List<MessageDto>();
            ShopActionResult<List<MessageDto>> shopActionResult = new ShopActionResult<List<MessageDto>>();
            var AdminListMess = messageRepository.GetAdminMessageRecive(userid);
            shopActionResult.Counts = AdminListMess.Count;
            shopActionResult.ItemCount = 4;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var messagelist = AdminListMess.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            shopActionResult.Page = page;
            foreach (var item in messagelist)
            {
                var userMessage = mapper.Map<MessageDto>(item);
                messageDtos.Add(userMessage);
            }
            shopActionResult.Data = messageDtos;
            return shopActionResult;

        }

        public ShopActionResult<List<MessageDto>> GetAllMessageAdmin(int page = 1)
        {
            ShopActionResult<List<MessageDto>> shopActionResult = new ShopActionResult<List<MessageDto>>();
            var RoleAdmin = roleRepository.GetByRoleAdmin();
            var userAdmin = userRoleRepository.GetByUserRole(RoleAdmin.Id);
            var listMessageAdmin = messageRepository.GetAdminMessageRecive(userAdmin.UserId);
            shopActionResult.Counts = listMessageAdmin.Count;
            shopActionResult.ItemCount = 5;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var ListMessageAdmin = listMessageAdmin.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Page = page;
            shopActionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            List<MessageDto> messageDtos = new List<MessageDto>();
            foreach (var item in ListMessageAdmin)
            {
                var message  = mapper.Map<MessageDto>(item);
                messageDtos.Add(message);
            }
            shopActionResult.Data = messageDtos;
            return shopActionResult;
        }

        public MessageDto GetById(int messageid)
        {
            var Message = messageRepository.GetById(messageid);
            var message = mapper.Map<MessageDto>(Message);
            return message;
        }

        public ShopActionResult<List<MessageDto>> GetUserMessageAll(Guid userid,int page = 1)
        {
            List<MessageDto> messageDtos = new List<MessageDto>();
            ShopActionResult<List<MessageDto>> shopActionResult = new ShopActionResult<List<MessageDto>>();
            var UserListMess = messageRepository.GetUserMessageAll(userid);
            shopActionResult.Counts = UserListMess.Count;
            shopActionResult.ItemCount = 4;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var messagelist = UserListMess.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Pages = Convert.ToInt32( Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
            shopActionResult.Page = page;
            foreach (var item in messagelist)
            {
                var userMessage = mapper.Map<MessageDto>(item);
                messageDtos.Add(userMessage);
            }
            shopActionResult.Data = messageDtos;
            return shopActionResult;
        }

        public void UpdateMessage(MessageDto messageDto)
        {
            var message = mapper.Map<Message>(messageDto);
            messageRepository.UpdateMessage(message);
        }
    }
}

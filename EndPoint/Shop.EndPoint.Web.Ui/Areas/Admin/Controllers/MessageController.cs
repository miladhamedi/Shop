using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Common;
using Shop.Core.Service.Dto.IndexDto;
using Shop.Core.Service.Services.Messages;
using Shop.Core.Service.Services.User;
using Shop.EndPoint.Web.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.EndPoint.Web.Ui.Areas.Admin.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService messageService;
        private readonly IMapper mapper;
        private readonly IUserService userService;

        public MessageController(IMessageService messageService,
            IMapper mapper,IUserService userService)
        {
            this.messageService = messageService;
            this.mapper = mapper;
            this.userService = userService;
        }


        public IActionResult Index(int page = 1)
        {
            ShopActionResult<List<MessageViewModel>> shopActionResult = new ShopActionResult<List<MessageViewModel>>();
            var ListMessageRecive = messageService.GetAllMessageAdmin(page);
            List<MessageViewModel> messageViewModels = new List<MessageViewModel>();

            shopActionResult.Page = ListMessageRecive.Page;
            shopActionResult.Pages = ListMessageRecive.Pages;

            foreach (var item in ListMessageRecive.Data)
            {
                var ListMessage = mapper.Map<MessageViewModel>(item);
                messageViewModels.Add(ListMessage);

            }
            shopActionResult.Data = messageViewModels;

            return View(shopActionResult);
        }



        public IActionResult Details(int messageid)
        {
            var message = messageService.GetById(messageid);
            var Message = mapper.Map<MessageViewModel>(message);
            return View(Message);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Guid usersendid, string replay, int messageid)
        {
            if (replay != null)
            {
                var user = User.Identity.Name;
                var quser = userService.GetByUserName(user);
                MessageDto messageDto = new MessageDto();
                messageDto.Confirm = true;
                messageDto.Date = DateTime.Now;
                messageDto.Text = replay;
                messageDto.UserIdRecive = usersendid;
                messageDto.UserIdSend = quser.Id;
                messageService.AddMessage(messageDto);

                var message = messageService.GetById(messageid);
                message.Confirm = true;
                messageService.UpdateMessage(message);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Details", new { messageid = messageid });
        }
    }
}

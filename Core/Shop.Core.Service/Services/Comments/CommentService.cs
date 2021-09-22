using AutoMapper;
using Shop.Common;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly IUserRepositroy userRepositroy;
        private readonly IProductRepository productRepository;
        private readonly ICommentRepository commentRepository;
        private readonly IMapper mapper;

        public CommentService(IUserRepositroy userRepositroy,
            IProductRepository productRepository,ICommentRepository commentRepository,IMapper mapper)
        {
            this.userRepositroy = userRepositroy;
            this.productRepository = productRepository;
            this.commentRepository = commentRepository;
            this.mapper = mapper;
        }

        public void AddComment(CommentDto commentDto)
        {
            var comment = mapper.Map<Comment>(commentDto);
            commentRepository.AddComment(comment);
        }

        public ShopActionResult<List<CommentDto>> AllCommentProfile(string username,int page = 1)
        {
            ShopActionResult<List<CommentDto>> shopActionResult = new ShopActionResult<List<CommentDto>>();
            var user = userRepositroy.GetByUserName(username);
            var Listcomment = commentRepository.GetCommentByUser(user.Id);
            if (Listcomment == null)
                return null;
            shopActionResult.Page = page;
            shopActionResult.ItemCount = 5;
            shopActionResult.Counts = Listcomment.Count;
            var skip = (page - 1) * shopActionResult.ItemCount;
            var AllComment = Listcomment.Skip(skip).Take(shopActionResult.ItemCount);
            shopActionResult.Pages = Convert.ToInt32( Math.Ceiling((decimal)shopActionResult.Counts / shopActionResult.ItemCount));
           
            
            List<CommentDto> commentDtos = new List<CommentDto>();
            foreach (var item in AllComment)
            {
                CommentDto commentDto = new CommentDto();
                commentDto.ProductName = productRepository.GetProductById(item.ProductId).Titel ?? null;
                commentDto.ProductId = item.ProductId;
                commentDto.Email = item.Email;
                commentDto.CommentId = item.CommentId;
                commentDto.Confirm = item.Confirm;
                commentDto.Date = item.Date;
                commentDto.UserId = item.UserId;
                commentDtos.Add(commentDto);


            }
            shopActionResult.Data = commentDtos;
            return shopActionResult;
        }

        public void DeleteComment(CommentDto commentDto)
        {
            var comment = mapper.Map<Comment>(commentDto);
            commentRepository.DeleteComment(comment);
        }

        public ShopActionResult<List<CommentDto>> GetAll(int page = 1)
        {
            ShopActionResult<List<CommentDto>> actionResult = new ShopActionResult<List<CommentDto>>();
            actionResult.Page = page;
            actionResult.ItemCount = 3;
            var skip = (page - 1) * actionResult.ItemCount;
            var ListComment = commentRepository.GetAllComment();
            actionResult.Counts = ListComment.Count();
            var AllCount = ListComment.Skip(skip).Take(actionResult.ItemCount);
            actionResult.Pages = Convert.ToInt32(Math.Ceiling((decimal)actionResult.Counts / actionResult.ItemCount));
            List<CommentDto> commentDtos = new List<CommentDto>();

            foreach (var item in AllCount)
            {
                var listcomment = mapper.Map<CommentDto>(item);
                commentDtos.Add(listcomment);

            }
            actionResult.Data = commentDtos;
            return actionResult;
        }

        public List<CommentDto> GetAllProId(int productid)
        {
            var listComment = commentRepository.AllCommentProId(productid);

            List<CommentDto> commentDtos = new List<CommentDto>();
            foreach (var item in listComment)
            {

                var ListComment = mapper.Map<CommentDto>(item);
                commentDtos.Add(ListComment);

            }
            return commentDtos;
        }

        public CommentDto GetCommentById(int commentid)
        {
            var Comment = commentRepository.GetCommentById(commentid);

            var comment = mapper.Map<CommentDto>(Comment);
            return comment;


        }

        public void UpdateComment(CommentDto commentDto)
        {
            var comment = mapper.Map<Comment>(commentDto);
            commentRepository.UpdateComment(comment);
        }
    }
}

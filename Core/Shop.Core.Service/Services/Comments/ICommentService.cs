using Shop.Common;
using Shop.Core.Domain.Entities;
using Shop.Core.Service.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Comments
{
    public interface ICommentService
    {
        List<CommentDto> GetAllProId(int productid);
        ShopActionResult<List<CommentDto>> AllCommentProfile(string username, int page = 1);
        void AddComment(CommentDto commentDto);
        ShopActionResult<List<CommentDto>> GetAll(int page = 1);
        void UpdateComment(CommentDto commentDto);
        CommentDto GetCommentById(int commentid);
        void DeleteComment(CommentDto commentDto);
    }
}

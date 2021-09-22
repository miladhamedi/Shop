using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface ICommentRepository
    {

        List<Comment> AllCommentProId(int productid);
        List<Comment> GetCommentByUser(Guid userid);
        void AddComment(Comment comment);
        List<Comment> GetAllComment();
        void UpdateComment(Comment comment);
        Comment GetCommentById(int commentid);
        void DeleteComment(Comment comment);
    }
}

using Microsoft.EntityFrameworkCore;
using Shop.Core.Contract.Repositories;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Infrastructure.Data.Sql.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ShopDbContext shopDbContext;

        public CommentRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
        }

        public void AddComment(Comment comment)
        {
            shopDbContext.Comments.Add(comment);
            shopDbContext.SaveChanges();
        }

        public List<Comment> AllCommentProId(int productid)
        {
            var listCommentPro = shopDbContext.Comments.Where(c => c.ProductId == productid && c.Confirm == true).AsNoTracking().ToList();
            if (listCommentPro == null)
                return null;
            return listCommentPro;
        }

        public void DeleteComment(Comment comment)
        {
            shopDbContext.Comments.Remove(comment);
            shopDbContext.SaveChanges();
        }

        public List<Comment> GetAllComment()
        {
            var Listcomment = shopDbContext.Comments.Include(c=>c.Product).OrderByDescending(c=>c.Date).AsNoTracking().ToList();
            return Listcomment;
        }

        public Comment GetCommentById(int commentid)
        {
            var comment = shopDbContext.Comments.Where(c => c.CommentId == commentid).AsNoTracking().FirstOrDefault();
            return comment;
        }

        public List<Comment> GetCommentByUser(Guid userid)
        {
            var listComment = shopDbContext.Comments.Where(c => c.UserId == userid).AsNoTracking().ToList();
            if (listComment == null)
                return null;
            return listComment;
        }

        public void UpdateComment(Comment comment)
        {
            shopDbContext.Comments.Attach(comment);
            shopDbContext.Entry(comment).State = EntityState.Modified;
            shopDbContext.SaveChanges();
        }
    }
}

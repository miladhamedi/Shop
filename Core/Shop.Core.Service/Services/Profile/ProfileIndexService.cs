using AutoMapper;
using Shop.Core.Contract.Repositories;
using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Profile
{
    public class ProfileIndexService : IProfileIndexService
    {
        private readonly IProductRepository productRepository;
        private readonly IArticleRepository articleRepository;
        private readonly ICommentRepository commentRepository;
        private readonly IUserRepositroy userRepositroy;
        private readonly IMapper mapper;
        private readonly IinvoiceRepository iinvoiceRepository;
        private readonly IMessageRepository messageRepository;

        public ProfileIndexService(IProductRepository productRepository, 
            IArticleRepository articleRepository,ICommentRepository
            commentRepository,IUserRepositroy userRepositroy,IMapper mapper,
            IinvoiceRepository iinvoiceRepository,IMessageRepository messageRepository)
        {
            this.productRepository = productRepository;
            this.articleRepository = articleRepository;
            this.commentRepository = commentRepository;
            this.userRepositroy = userRepositroy;
            this.mapper = mapper;
            this.iinvoiceRepository = iinvoiceRepository;
            this.messageRepository = messageRepository;
        }
        public List<ArticleDto> GetAllArticle()
        {
            List<ArticleDto> articleDtos = new List<ArticleDto>();
            var listArticle = articleRepository.GetAllArticle();
            foreach (var item in listArticle)
            {
                var article = mapper.Map<ArticleDto>(item);
                articleDtos.Add(article);
            }

            return articleDtos;
        }

        public List<CommentDto> GetAllComment()
        {
            List<CommentDto> commentDtos = new List<CommentDto>();
            var listComment = commentRepository.GetAllComment();
            foreach (var item in listComment)
            {
                var comment = mapper.Map<CommentDto>(item);
                commentDtos.Add(comment);
            }

            return commentDtos;
        }

        public List<ProductDto> GetAllProduct()
        {
            List<ProductDto> productDtos = new List<ProductDto>();
            var listProduct = productRepository.GetAllProduct();
            foreach (var item in listProduct)
            {
                var prodcut = mapper.Map<ProductDto>(item);
                productDtos.Add(prodcut);
            }
            return productDtos;

        }

        public List<UserDto> GetAllUser()
        {
            List<UserDto> addressUserDtos = new List<UserDto>();
            var listUser = userRepositroy.GetAllUser();
            foreach (var item in listUser)
            {
                var user = mapper.Map<UserDto>(item);
                addressUserDtos.Add(user);
            }


            return addressUserDtos;
        }

        public List<InvoiceDto> GetLastInvoice()
        {
            List<InvoiceDto> invoiceDtos = new List<InvoiceDto>();
            var LastInvoice = iinvoiceRepository.GetLastInvoice();
            foreach (var item in LastInvoice)
            {
                var invoice = mapper.Map<InvoiceDto>(item);
                invoiceDtos.Add(invoice);
            }

            return invoiceDtos;
        }

        public List<ProductDto> GetLastProduct()
        {
            List<ProductDto> productDtos = new List<ProductDto>();
            var LastProduct = productRepository.LastProduct();
            foreach (var item in LastProduct)
            {
                var lastproduct = mapper.Map<ProductDto>(item);
                productDtos.Add(lastproduct);
            }

            return productDtos;
        }

        public List<UserDto> GetLastUser()
        {
            List<UserDto> addressUserDtos = new List<UserDto>();
            var LastUser = userRepositroy.GetLastUser();
            foreach (var item in LastUser)
            {
                var lastuser = mapper.Map<UserDto>(item);
                addressUserDtos.Add(lastuser);
            }

            return addressUserDtos;
        }

        public List<MessageDto> GetMessageRecive(string username)
        {
            List<MessageDto> messageDtos = new List<MessageDto>();
            var user = userRepositroy.GetByUserName(username);
            var Listmessage = messageRepository.GetMessageAdmin(user.Id);
            foreach (var item in Listmessage)
            {
                var message = mapper.Map<MessageDto>(item);
                messageDtos.Add(message);
            }
            return messageDtos;
        }

        public List<InvoiceDto> ListInvoice()
        {
            List<InvoiceDto> invoiceDtos = new List<InvoiceDto>();
            var listInvoice = iinvoiceRepository.GetAll();
            foreach (var item in listInvoice)
            {
                var invice = mapper.Map<InvoiceDto>(item);
                invoiceDtos.Add(invice);
            }

            return invoiceDtos;
        }
    }
}

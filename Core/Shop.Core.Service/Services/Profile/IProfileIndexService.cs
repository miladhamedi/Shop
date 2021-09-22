using Shop.Core.Service.Dto;
using Shop.Core.Service.Dto.IndexDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Service.Services.Profile
{
    public interface IProfileIndexService
    {
        List<UserDto> GetAllUser();
        List<CommentDto> GetAllComment();
        List<ArticleDto> GetAllArticle();
        List<ProductDto> GetAllProduct();
        List<ProductDto> GetLastProduct();
        List<InvoiceDto> GetLastInvoice();
        List<UserDto> GetLastUser();
        List<InvoiceDto> ListInvoice();
        List<MessageDto> GetMessageRecive(string username);
    }
}

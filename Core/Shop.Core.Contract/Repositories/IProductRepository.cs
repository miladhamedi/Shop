using Shop.Common;
using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Core.Contract.Repositories
{
    public interface IProductRepository
    {

        List<Product> GetByCategoryId(int categoryid);
        Product GetProductById(int productid);
        void UpdateProduct(Product product);
        List<Product> SearchProduct(string title);
        List<Product> searchPrice(int categoryid, decimal min_price, decimal max_price);
        List<Product> GetAllProduct();
        List<Product> LastProduct();
        int AddProduct(Product product);
        Product GetByProductId(int productid);

    }
}

﻿using Shop.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Contract.Repositories
{
    public interface IProductIndexRepository
    {
        List<Product> InexpensiveProduct();
        List<Product> NewProduct();
        List<Product> Mostdiscounts();
        List<ShoppingCart> Bestselling();
        

    }
}

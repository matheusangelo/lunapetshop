using System;
using System.Collections.Generic;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Repository
{
    public interface IProductRespository
    {
        Product GetById(Guid Id);
        Product GetByEmail(string Email);
        List<Product> GetByUserId(Guid Id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
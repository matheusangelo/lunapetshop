using System;
using System.Collections.Generic;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Repository
{
    public interface IProductRespository
    {
        Product GetById(Guid Id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
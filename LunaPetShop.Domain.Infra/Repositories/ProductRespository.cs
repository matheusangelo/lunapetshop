using System;
using System.Collections.Generic;
using System.Linq;
using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Infra.Contexts;
using LunaPetShop.Domain.Queries;
using LunaPetShop.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace LunaPetShop.Domain.Infra.Respositories
{
    public class ProductRepository : IProductRespository
    {
        private readonly LunaPetShopContext _lunaPetShopContext;
        public ProductRepository(LunaPetShopContext lunaPetShopContext)
        {
            _lunaPetShopContext = lunaPetShopContext;
        }

        public void Add(Product product)
        {
            _lunaPetShopContext.products.Add(product);
            _lunaPetShopContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByUserId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
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
            _lunaPetShopContext.products.Remove(product);
            _lunaPetShopContext.SaveChanges();
        }

        public Product GetById(Guid Id)
        {
            return _lunaPetShopContext.products
                                      .AsQueryable()
                                      .Where(ProductQuery.GetById(Id))
                                      .FirstOrDefault();
        }
        public void Update(Product product)
        {
            _lunaPetShopContext.Entry(product).State = EntityState.Modified;
            _lunaPetShopContext.SaveChanges();

        }
    }
}
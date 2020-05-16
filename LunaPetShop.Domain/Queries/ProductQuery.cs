using System;
using System.Linq.Expressions;
using LunaPetShop.Domain.Entities;

namespace LunaPetShop.Domain.Queries
{
    public static class ProductQuery
    {
        public static Expression<Func<Product, bool>> GetById(Guid Id)
        {
            return x => x.Id == Id;
        }
    }
}
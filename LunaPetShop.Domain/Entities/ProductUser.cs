using System;
using System.Collections.Generic;

namespace LunaPetShop.Domain.Entities
{
    public class ProductUser : Entity
    {
        public Guid UserId { get; private set; }

        public User User { get; private set; }

        public Guid ProductId { get; private set; }

        public Product Product { get; private set; }


        public double getTotalPrize(List<Product> products)
        {
            double total = 0;

            foreach (var product in products)
            {
                total = total + product.Price;
            }

            return total;
        }

    }

}
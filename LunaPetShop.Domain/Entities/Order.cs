using System;
using System.Collections.Generic;

namespace LunaPetShop.Domain.Entities
{
    public class Order : Entity
    {
        public Order()
        {
            this.Products = new List<Product>();
        }
        public Guid UserId { get; private set; }

        public List<Product> Products { get; private set; }
        public double TotalPrize { get {return getTotalPrize();}}

        public double getTotalPrize()
        {
            double total = 0;
            
            foreach (var product in this.Products)
            {
                total = total + product.Price;
            }
            
            return total;
        }

    }

}
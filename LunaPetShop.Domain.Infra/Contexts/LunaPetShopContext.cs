using LunaPetShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LunaPetShop.Domain.Infra.Contexts
{
    public class LunaPetShopContext : DbContext
    {
        public LunaPetShopContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> users {get; set;}
    }
}
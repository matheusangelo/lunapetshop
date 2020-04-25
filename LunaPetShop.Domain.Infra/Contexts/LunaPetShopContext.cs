using LunaPetShop.Domain.Entities;
using LunaPetShop.Domain.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace LunaPetShop.Domain.Infra.Contexts
{
    public class LunaPetShopContext : DbContext
    {
        public LunaPetShopContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> users {get; set;}

        public DbSet<Pet> pets {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());

        }

    }
}
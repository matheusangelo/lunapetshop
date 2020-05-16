using System;
using LunaPetShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LunaPetShop.Domain.Infra.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");

            builder.Property(p => p.Id)
                    .IsRequired()
                    .HasColumnName("ID");

            builder.Property(p => p.Name)
                    .HasColumnType("varchar(150)")
                    .IsRequired()
                    .HasColumnName("NAME");

            builder.Property(p => p.AnimalType)
                    .IsRequired()
                    .HasColumnName("ANIMAL_TYPE");

            builder.Property(p => p.Price)
                    .IsRequired()
                    .HasColumnName("PRICE");

            builder.Property(p => p.Amount)
                    .IsRequired()
                    .HasColumnName("AMOUNT");

            builder.Property(p => p.Reviews)
                    .HasColumnName("REVIEWS");

        }

    }
}

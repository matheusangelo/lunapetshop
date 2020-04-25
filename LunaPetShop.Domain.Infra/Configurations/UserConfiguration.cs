using System;
using LunaPetShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LunaPetShop.Domain.Infra.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");

            builder.Property(p => p.Name)
                    .HasColumnType("varchar(150)")
                    .IsRequired()
                    .HasColumnName("NAME");

            builder.Property(p => p.SurName)
                    .IsRequired()
                    .HasColumnName("SURNAME");

            builder.Property(p => p.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL");

            builder.Property(p => p.Password)
                    .HasColumnName("PASSWORD");

        }
    }
}

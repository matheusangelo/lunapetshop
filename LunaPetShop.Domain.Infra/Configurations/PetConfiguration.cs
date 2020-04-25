using System;
using LunaPetShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LunaPetShop.Domain.Infra.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("PET");

            builder.Property(p => p.Name)
                    .HasColumnType("varchar(150)")
                    .IsRequired()
                    .HasColumnName("NAME");

            builder.Property(p => p.Weigth)
                    .IsRequired()
                    .HasColumnName("WEIGTH");

            builder.Property(p => p.Age)
                    .IsRequired()
                    .HasColumnName("AGE");

            builder.Property(p => p.Sex)
                    .HasColumnName("SEX");

            builder.Property(p => p.Breed)
                    .HasColumnName("BREED");

            builder.Property(p => p.Castrated)
                    .HasColumnType("bit")
                    .HasColumnName("CASTRATED");

            builder.Property(p => p.Size)
                    .HasColumnName("SIZE");

                //fluent api relationship
            builder.HasOne(p => p.User)
                   .WithMany(u => u.Pets)
                   .HasForeignKey(u => u.UserId);
        }

    }
}

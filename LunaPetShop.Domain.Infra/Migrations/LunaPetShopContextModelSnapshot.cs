﻿// <auto-generated />
using System;
using LunaPetShop.Domain.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LunaPetShop.Domain.Infra.Migrations
{
    [DbContext(typeof(LunaPetShopContext))]
    partial class LunaPetShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LunaPetShop.Domain.Entities.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnName("AGE")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnName("BREED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Castrated")
                        .HasColumnName("CASTRATED")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Sex")
                        .HasColumnName("SEX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Size")
                        .HasColumnName("SIZE")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Weigth")
                        .HasColumnName("WEIGTH")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PET");
                });

            modelBuilder.Entity("LunaPetShop.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .HasColumnName("PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnName("SURNAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("USER");
                });

            modelBuilder.Entity("LunaPetShop.Domain.Entities.Pet", b =>
                {
                    b.HasOne("LunaPetShop.Domain.Entities.User", "User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

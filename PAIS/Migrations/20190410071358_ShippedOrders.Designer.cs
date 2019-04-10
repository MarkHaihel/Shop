﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PAIS.Models;

namespace PAIS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190410071358_ShippedOrders")]
    partial class ShippedOrders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PAIS.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<string>("Anotation");

                    b.Property<string>("Author");

                    b.Property<string>("Binder");

                    b.Property<string>("Description");

                    b.Property<string>("Format");

                    b.Property<string>("ISBNCode");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("PublicationDate");

                    b.Property<string>("PublicationType");

                    b.HasKey("BookID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("PAIS.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID");

                    b.Property<int?>("OrderID");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineID");

                    b.HasIndex("BookID");

                    b.HasIndex("OrderID");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("PAIS.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<bool>("GiftWrap");

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Shipped");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PAIS.Models.CartLine", b =>
                {
                    b.HasOne("PAIS.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID");

                    b.HasOne("PAIS.Models.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");
                });
#pragma warning restore 612, 618
        }
    }
}

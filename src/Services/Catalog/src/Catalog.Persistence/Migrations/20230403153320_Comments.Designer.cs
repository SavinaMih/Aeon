﻿// <auto-generated />
using System;
using Catalog.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Persistence.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    [Migration("20230403153320_Comments")]
    partial class Comments
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Catalog.Domain.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("402af308-a6b0-4574-acf5-dc3d57d3cad9"),
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = new Guid("3933bc2a-8aa8-4e61-b383-db72679c2547"),
                            Name = "Vegetables"
                        });
                });

            modelBuilder.Entity("Catalog.Domain.Comments.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Catalog.Domain.Comments.Upvote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("Upvotes");
                });

            modelBuilder.Entity("Catalog.Domain.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c15cc235-1596-46d3-b91b-8d66d0e0e715"),
                            CategoryId = new Guid("402af308-a6b0-4574-acf5-dc3d57d3cad9"),
                            Description = "Orange fruit",
                            Discount = 0m,
                            Image = "",
                            Price = 2m,
                            Quantity = 2,
                            Title = "Orange"
                        },
                        new
                        {
                            Id = new Guid("f69acb2a-06cd-40ac-907c-df9d348f6c82"),
                            CategoryId = new Guid("402af308-a6b0-4574-acf5-dc3d57d3cad9"),
                            Description = "Red fruit",
                            Discount = 0m,
                            Image = "",
                            Price = 3m,
                            Quantity = 3,
                            Title = "Apple"
                        },
                        new
                        {
                            Id = new Guid("9fae5394-bb21-446b-80b9-c3ed55bc1f51"),
                            CategoryId = new Guid("3933bc2a-8aa8-4e61-b383-db72679c2547"),
                            Description = "Green vegetable",
                            Discount = 0m,
                            Image = "",
                            Price = 4m,
                            Quantity = 1,
                            Title = "Cucumber"
                        },
                        new
                        {
                            Id = new Guid("dcf394e6-5c38-4e32-8192-f2d0982a76bd"),
                            CategoryId = new Guid("3933bc2a-8aa8-4e61-b383-db72679c2547"),
                            Description = "Red vegetable",
                            Discount = 0m,
                            Image = "",
                            Price = 1m,
                            Quantity = 6,
                            Title = "Tomato"
                        });
                });

            modelBuilder.Entity("Catalog.Domain.Comments.Comment", b =>
                {
                    b.HasOne("Catalog.Domain.Products.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Catalog.Domain.Comments.Upvote", b =>
                {
                    b.HasOne("Catalog.Domain.Comments.Comment", "Comment")
                        .WithMany("Upvotes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Catalog.Domain.Products.Product", b =>
                {
                    b.HasOne("Catalog.Domain.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Catalog.Domain.Categories.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Catalog.Domain.Comments.Comment", b =>
                {
                    b.Navigation("Upvotes");
                });

            modelBuilder.Entity("Catalog.Domain.Products.Product", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

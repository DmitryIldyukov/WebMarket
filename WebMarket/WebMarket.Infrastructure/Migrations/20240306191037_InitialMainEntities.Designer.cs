﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebMarket.Data;

#nullable disable

namespace WebMarket.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240306191037_InitialMainEntities")]
    partial class InitialMainEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebMarket.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_baskets");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_baskets_user_id");

                    b.ToTable("baskets", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.Dictionaries.DictCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_dict_categories");

                    b.ToTable("dict_categories", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_feedbacks");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_feedbacks_product_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_feedbacks_user_id");

                    b.ToTable("feedbacks", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric")
                        .HasColumnName("cost");

                    b.Property<int>("Count")
                        .HasColumnType("integer")
                        .HasColumnName("count");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("DictCategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("dict_category_id");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("DictCategoryId")
                        .HasDatabaseName("ix_products_dict_category_id");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.ProductInBasket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("integer")
                        .HasColumnName("basket_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_product_in_baskets");

                    b.HasIndex("BasketId")
                        .HasDatabaseName("ix_product_in_baskets_basket_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_product_in_baskets_product_id");

                    b.ToTable("product_in_baskets", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role_name");

                    b.Property<int>("RoleType")
                        .HasColumnType("integer")
                        .HasColumnName("role_type");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_roles");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("integer")
                        .HasColumnName("basket_id");

                    b.Property<DateOnly?>("BirthDay")
                        .HasColumnType("date")
                        .HasColumnName("birth_day");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean")
                        .HasColumnName("is_deleted");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("BasketId")
                        .HasDatabaseName("ix_users_basket_id");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_users_role_id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("WebMarket.Entities.Basket", b =>
                {
                    b.HasOne("WebMarket.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_baskets_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebMarket.Entities.Feedback", b =>
                {
                    b.HasOne("WebMarket.Entities.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_feedbacks_products_product_id");

                    b.HasOne("WebMarket.Entities.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_feedbacks_users_user_id");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebMarket.Entities.Product", b =>
                {
                    b.HasOne("WebMarket.Entities.Dictionaries.DictCategory", "DictCategory")
                        .WithMany()
                        .HasForeignKey("DictCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_dict_categories_dict_category_id");

                    b.Navigation("DictCategory");
                });

            modelBuilder.Entity("WebMarket.Entities.ProductInBasket", b =>
                {
                    b.HasOne("WebMarket.Entities.Basket", "Basket")
                        .WithMany("Products")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_in_baskets_baskets_basket_id");

                    b.HasOne("WebMarket.Entities.Product", "Product")
                        .WithMany("Baskets")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_in_baskets_products_product_id");

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebMarket.Entities.User", b =>
                {
                    b.HasOne("WebMarket.Entities.Basket", "Basket")
                        .WithMany()
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_baskets_basket_id");

                    b.HasOne("WebMarket.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_users_roles_role_id");

                    b.Navigation("Basket");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebMarket.Entities.Basket", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebMarket.Entities.Product", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("WebMarket.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebMarket.Entities.User", b =>
                {
                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
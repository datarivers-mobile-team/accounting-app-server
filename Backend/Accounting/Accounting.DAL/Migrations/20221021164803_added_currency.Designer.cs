﻿// <auto-generated />
using System;
using Accounting.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Accounting.DAL.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    [Migration("20221021164803_added_currency")]
    partial class added_currency
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Accounting.Model.Account.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IconId")
                        .HasColumnType("int");

                    b.Property<int>("StartAmount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountId");

                    b.HasIndex("ColorId");

                    b.HasIndex("IconId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Accounting.Model.Category.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("IconId")
                        .HasColumnType("int");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("IconId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Accounting.Model.Color.Entities.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<int>("ColorType")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Accounting.Model.Currency.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CurrencyId"), 1L, 1);

                    b.Property<int?>("IconId")
                        .HasColumnType("int");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrencyId");

                    b.HasIndex("IconId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Accounting.Model.Icon.Entities.Icon", b =>
                {
                    b.Property<int>("IconId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IconId"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<byte>("IconType")
                        .HasColumnType("tinyint");

                    b.Property<int>("Oeder")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IconId");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("Accounting.Model.UserAccount.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("AccessMode")
                        .HasColumnType("tinyint");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("Accounting.Model.UserContact.Entities.UserContact", b =>
                {
                    b.Property<int>("UserContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserContactId"), 1L, 1);

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("UserContactId");

                    b.HasIndex("ContactId");

                    b.HasIndex("OwnerId");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("Accounting.Model.Users.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("Isdeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("PreferredCurrency")
                        .HasColumnType("int");

                    b.Property<string>("RefCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Accounting.Model.UserToken.Entities.UserToken", b =>
                {
                    b.Property<int>("UserTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTokenId"), 1L, 1);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserTokenId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Accounting.Model.Account.Entities.Account", b =>
                {
                    b.HasOne("Accounting.Model.Color.Entities.Color", null)
                        .WithMany("Accounts")
                        .HasForeignKey("ColorId");

                    b.HasOne("Accounting.Model.Icon.Entities.Icon", null)
                        .WithMany("Accounts")
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Accounting.Model.Category.Entities.Category", b =>
                {
                    b.HasOne("Accounting.Model.Color.Entities.Color", null)
                        .WithMany("Categories")
                        .HasForeignKey("ColorId");

                    b.HasOne("Accounting.Model.Icon.Entities.Icon", null)
                        .WithMany("Categories")
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Accounting.Model.Currency.Entities.Currency", b =>
                {
                    b.HasOne("Accounting.Model.Icon.Entities.Icon", null)
                        .WithMany("Currencies")
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("Accounting.Model.UserAccount.Entities.UserAccount", b =>
                {
                    b.HasOne("Accounting.Model.Account.Entities.Account", null)
                        .WithMany("UserAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accounting.Model.Users.Entities.User", null)
                        .WithMany("UserAccounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accounting.Model.UserContact.Entities.UserContact", b =>
                {
                    b.HasOne("Accounting.Model.Users.Entities.User", "User")
                        .WithMany("UserOwner")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Accounting.Model.Users.Entities.User", "UserOwner")
                        .WithMany("UserContacts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("UserOwner");
                });

            modelBuilder.Entity("Accounting.Model.UserToken.Entities.UserToken", b =>
                {
                    b.HasOne("Accounting.Model.Users.Entities.User", "User")
                        .WithOne("UserToken")
                        .HasForeignKey("Accounting.Model.UserToken.Entities.UserToken", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Accounting.Model.Account.Entities.Account", b =>
                {
                    b.Navigation("UserAccounts");
                });

            modelBuilder.Entity("Accounting.Model.Color.Entities.Color", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Accounting.Model.Icon.Entities.Icon", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Categories");

                    b.Navigation("Currencies");
                });

            modelBuilder.Entity("Accounting.Model.Users.Entities.User", b =>
                {
                    b.Navigation("UserAccounts");

                    b.Navigation("UserContacts");

                    b.Navigation("UserOwner");

                    b.Navigation("UserToken")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

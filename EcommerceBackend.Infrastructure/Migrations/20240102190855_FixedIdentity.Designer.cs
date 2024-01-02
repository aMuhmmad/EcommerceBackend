﻿// <auto-generated />
using System;
using EcommerceBackend.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceBackend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240102190855_FixedIdentity")]
    partial class FixedIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceBackend.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "All"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Deals"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Amazon"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fashion"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Home"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mobiles"
                        });
                });

            modelBuilder.Entity("EcommerceBackend.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attribute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AverageRating")
                        .HasColumnType("int");

                    b.Property<string>("Badge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Ratings")
                        .HasColumnType("int");

                    b.Property<int?>("ShippingCost")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attribute = "Paperback",
                            AverageRating = 4,
                            Badge = "seller",
                            Brand = "Lee Child",
                            CategoryId = 2,
                            Description = "The gripping new Jack Reacher thriller from the No.1 bestselling authors Lee Child and Andrew Child.",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205068/amazon-image/product_0_lp8pq7.jpg",
                            Name = "No Plan B",
                            OldPrice = 22.00m,
                            Price = 11.00m,
                            Ratings = 24089,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 2,
                            Attribute = "Hardcover",
                            AverageRating = 5,
                            Badge = "choice",
                            Brand = "Guinness World Records",
                            CategoryId = 2,
                            Description = "The 2023 edition takes readers on a journey that's out of this world! ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205069/amazon-image/product_1_fy5tnk.jpg",
                            Name = "Guinness World Records 2023",
                            OldPrice = 22.00m,
                            Price = 8.50m,
                            Ratings = 929,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 3,
                            Attribute = "Paperback",
                            AverageRating = 4,
                            Badge = "choice",
                            Brand = "Jamie Oliver",
                            CategoryId = 2,
                            Description = "Give them the simplest cookbook ever this Christmas . . . Jamie's back to basics with over 120 simple, delicious, ONE pan recipes",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205069/amazon-image/product_2_dwmued.jpg",
                            Name = "One: Simple One-Pan Wonders",
                            OldPrice = 23.00m,
                            Price = 13.00m,
                            Ratings = 2993,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 4,
                            Attribute = "Paperback",
                            AverageRating = 5,
                            Brand = "Richard Osman",
                            CategoryId = 2,
                            Description = "Except trouble is never far away where the Thursday Murder Club is concerned. ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205069/amazon-image/product_3_zubcys.jpg",
                            Name = "The Bullet That Missed: (The Thursday Murder Club 3)",
                            OldPrice = 20.00m,
                            Price = 10.00m,
                            Ratings = 29283,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 5,
                            Attribute = "Hardcover",
                            AverageRating = 4,
                            Badge = "limited",
                            Brand = "Jordan Moore",
                            CategoryId = 2,
                            Description = "Want to impress your friends and family with both useful, worthless but undeniably interesting facts? ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704207577/amazon-image/product_4_tnsryj.jpg",
                            Name = "Interesting Facts For Curious Minds",
                            OldPrice = 13.99m,
                            Price = 10.90m,
                            Ratings = 885,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 6,
                            Attribute = "Paperback",
                            AverageRating = 4,
                            Badge = "choice",
                            Brand = "Colleen Hoover",
                            CategoryId = 2,
                            Description = "Colleen Hoover tells fan favourite Atlas’s side of the story and shares what comes next in this long-anticipated sequel to the #1 Sunday Times bestseller It Ends with Us ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205089/amazon-image/product_5_n8kwqi.jpg",
                            Name = "It Start with Us",
                            OldPrice = 14.99m,
                            Price = 7.00m,
                            Ratings = 44402,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 7,
                            Attribute = "Paperback",
                            AverageRating = 5,
                            Badge = "choice",
                            Brand = "David Walliams",
                            CategoryId = 2,
                            Description = "Go back to the Space Race with No.1 bestselling author David Walliams for a breathless cinematic adventure full of mystery, action, laughs and surprises ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205105/amazon-image/product_6_qvypaf.jpg",
                            Name = "SPACEBOY",
                            OldPrice = 14.99m,
                            Price = 7.00m,
                            Ratings = 877,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 8,
                            Attribute = "Hardcover",
                            AverageRating = 4,
                            Brand = "Bonnie Garmus",
                            CategoryId = 2,
                            Description = "Chemist Elizabeth Zott is not your average woman. In fact, Elizabeth Zott would be the first to point out that there is no such thing.",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205105/amazon-image/product_7_amdwix.jpg",
                            Name = "Lessons in Chemistry",
                            OldPrice = 16.99m,
                            Price = 8.00m,
                            Ratings = 62749,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 9,
                            Attribute = "Hardcover",
                            AverageRating = 4,
                            Badge = "choice",
                            Brand = "Storm Dunlop",
                            CategoryId = 2,
                            Description = "From the UK’s Number One Astronomy publisher, this is the bestselling stargazing handbook to the planets, stars and constellations visible from the northern hemisphere.",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704207647/amazon-image/product_8_small_jqwaym.jpg",
                            Name = "2023 Guide to the Night Sky",
                            OldPrice = 6.99m,
                            Price = 4.79m,
                            Ratings = 134,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 10,
                            Attribute = "Streaming Device",
                            AverageRating = 4,
                            Badge = "choice",
                            Brand = "Amazon",
                            CategoryId = 7,
                            Description = "Our most affordable Fire TV Stick—enjoy fast streaming in Full HD. Comes with Alexa Voice Remote Lite. Easy to set up, stays hidden—plug in behind your TV, turn on the TV and connect to the internet to get set up. ",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205106/amazon-image/product_9_cjqxx5.jpg",
                            Name = "Fire TV Stick Lite",
                            OldPrice = 40.99m,
                            Price = 34.99m,
                            Ratings = 17602,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 11,
                            Attribute = "Polo",
                            AverageRating = 3,
                            Brand = "Hugo Boss",
                            CategoryId = 5,
                            Description = "Shirt; BOSS; HUGO BOSS. 100% Cotton. Machine Wash. Fastening= Pull On. Collar Style= Classic. Slim Fit",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205107/amazon-image/product_10_watoql.jpg",
                            Name = "BOSS Men's Prime Shirt",
                            OldPrice = 45.00m,
                            Price = 42.95m,
                            Ratings = 10,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 12,
                            Attribute = "iPad",
                            AverageRating = 5,
                            Badge = "choice",
                            Brand = "Apple",
                            CategoryId = 8,
                            Description = "Striking 10.9-inch Liquid Retina display with True Tone. A14 Bionic chip with 6-core CPU and 4-core GPU. 12MP Wide back camera",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205112/amazon-image/product_11_cqtsll.jpg",
                            Name = "Apple 2022 10.9-inch iPad",
                            OldPrice = 549.00m,
                            Price = 499.00m,
                            Ratings = 262,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 13,
                            Attribute = "Coffee Machine",
                            AverageRating = 4,
                            Badge = "limited",
                            Brand = "Nescafé",
                            CategoryId = 7,
                            Description = "Over 40 beverage varieties including Nescafe Dolce Gusto or starbucks coffees. Hot and cold drink capability for hot and cold beverages prepared with one easy move of the machine’s manual lever. Easy to clean as all the coffee grinds stay in the pods there is no mess, no fuss",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205112/amazon-image/product_12_cwjbfh.jpg",
                            Name = "DeLonghi Nescafé Dolce Coffee Machine",
                            OldPrice = 79.99m,
                            Price = 34.99m,
                            Ratings = 6283,
                            Status = true,
                            Stock = 1
                        },
                        new
                        {
                            Id = 14,
                            Attribute = "Mobile",
                            AverageRating = 5,
                            Badge = "seller",
                            Brand = "Apple",
                            CategoryId = 8,
                            Description = "6.1-inch Super Retina XDR display featuring Always-On and ProMotion. Dynamic Island, a magical new way to interact with iPhone. 48MP Main camera for up to 4x greater resolution. Cinematic mode now in 4K Dolby Vision up to 30 fps",
                            Image = "https://res.cloudinary.com/ding7zvwj/image/upload/v1704205112/amazon-image/product_13_rtlglc.jpg",
                            Name = "Apple iPhone 14 Pro - Deep Purple",
                            OldPrice = 1099.00m,
                            Price = 1039.00m,
                            Ratings = 1047,
                            Status = true,
                            Stock = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EcommerceBackend.Core.Models.Product", b =>
                {
                    b.HasOne("EcommerceBackend.Core.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EcommerceBackend.Core.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

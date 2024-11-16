﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20241115153252_publisherBookCount")]
    partial class publisherBookCount
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCart", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("CartsId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "CartsId");

                    b.HasIndex("CartsId");

                    b.ToTable("BookCart");
                });

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "USA",
                            FirstName = "Nora",
                            ImagePath = "https://knigogo.top/wp-content/uploads/2023/01/Nora-Sakavic-237x308.jpg",
                            LastName = "Sakavic"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Ukraine",
                            FirstName = "Hilarion",
                            ImagePath = "https://forbes.ua/static/storage/thumbs/414x671/5/1f/7f751b94-b3bb5c9efa73b215c208131abc3a41f5.jpg?v=4355_2",
                            LastName = "Pavlyuk"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "USA",
                            FirstName = "Erin",
                            ImagePath = "https://mybookshelf.com.ua/files/Erin.jpg",
                            LastName = "Morgenstern"
                        },
                        new
                        {
                            Id = 4,
                            Biography = "Ukraine",
                            FirstName = "V.",
                            LastName = "Tsybulska"
                        },
                        new
                        {
                            Id = 5,
                            Biography = "Germany",
                            FirstName = "Thomas",
                            ImagePath = "https://static.yakaboo.ua/media/entity/author/1/_/1_5_2.jpg",
                            LastName = "Mann"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "USA",
                            FirstName = "Ray",
                            ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeCIh-DgHkRN6kF01iw5EVC7AMAR8PFbUeNg&s",
                            LastName = "Bradbury"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "USA",
                            FirstName = "Harper",
                            ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8pdhxKYlV1EYfjGfTf9P-EpF2LGQn8Ev2pg&s",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = 8,
                            Biography = "UK",
                            FirstName = "Charlotte",
                            ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtdV2etWBDVg4tdHyaCERfMZNqmPTUMNhJMQ&s",
                            LastName = "Brontë"
                        },
                        new
                        {
                            Id = 9,
                            Biography = "Ukraine",
                            FirstName = "Grigory",
                            ImagePath = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg/800px-%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg",
                            LastName = "Kvitky-Osnovyanenko"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("EBookPrice")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("ImagePath")
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberOfPages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("PaperPrice")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Year")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CategoryID = 3,
                            Count = 10,
                            Description = "Neil Josten is the newest addition to the Palmetto State University Exy team.",
                            EBookPrice = 160m,
                            ISBN = "1516801512",
                            ImagePath = "https://yabooks.com.ua/content/images/35/311x480l50nn0/49283594893207.jpeg",
                            Language = "English",
                            NumberOfPages = 260,
                            PaperPrice = 570m,
                            PublisherId = 1,
                            Title = "The Foxhole Court",
                            Year = 2013
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CategoryID = 2,
                            Count = 17,
                            Description = "he Foxes are a fractured mess, but their latest disaster might be the miracle they've always needed to come together as a team. The one person standing in their way is Andrew, and the only one who can break through his personal barriers is Neil.",
                            EBookPrice = 180m,
                            ISBN = "97856044580",
                            ImagePath = "https://yabooks.com.ua/content/images/36/311x480l50nn0/94468796443708.jpeg",
                            Language = "English",
                            NumberOfPages = 432,
                            PaperPrice = 590m,
                            PublisherId = 1,
                            Title = "The Raven King",
                            Year = 2013
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            CategoryID = 3,
                            Count = 13,
                            Description = "He knew when he came to PSU he wouldn't survive the year, but with his death right around the corner he's got more reasons than ever to live. ",
                            EBookPrice = 280m,
                            ISBN = "9786171701090",
                            ImagePath = "https://yabooks.com.ua/content/images/37/311x480l50nn0/26706706797137.jpeg",
                            Language = "English",
                            NumberOfPages = 448,
                            PaperPrice = 650m,
                            PublisherId = 1,
                            Title = "The King's Men",
                            Year = 2014
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            CategoryID = 8,
                            Count = 20,
                            Description = "\"I see you are interested in the dark\" is a story about impenetrable human indifference and the darkness within us",
                            EBookPrice = 300m,
                            ISBN = "9786176798323",
                            ImagePath = "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/y/a/ya_bachu_vas_cikavytj_pitjma_cover_full.jpg",
                            Language = "Ukrainian",
                            NumberOfPages = 664,
                            PaperPrice = 450m,
                            PublisherId = 7,
                            Title = "I see you are interested in the dark",
                            Year = 2022
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 6,
                            CategoryID = 6,
                            Count = 24,
                            Description = "Fahrenheit 451 tells the story of Guy Montag and his transformation from a book-burning fireman to a book-reading rebel. ",
                            EBookPrice = 160m,
                            ISBN = "9783060311354",
                            ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqDywXlxk7PpGQaNR5B50K-JGw36JBrokCwA&s",
                            Language = "Ukrainian",
                            NumberOfPages = 272,
                            PaperPrice = 570m,
                            PublisherId = 6,
                            Title = "451° Fahrenheit",
                            Year = 1953
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookCount")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookCount = 0,
                            CategoryName = "Novel"
                        },
                        new
                        {
                            Id = 2,
                            BookCount = 0,
                            CategoryName = "Contemporary literature"
                        },
                        new
                        {
                            Id = 3,
                            BookCount = 0,
                            CategoryName = "Young Adult"
                        },
                        new
                        {
                            Id = 4,
                            BookCount = 0,
                            CategoryName = "Mystical Horror"
                        },
                        new
                        {
                            Id = 5,
                            BookCount = 0,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            BookCount = 0,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            BookCount = 0,
                            CategoryName = "Southern Gothic Bildungsroman"
                        },
                        new
                        {
                            Id = 8,
                            BookCount = 0,
                            CategoryName = "Fiction"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

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

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookCount")
                        .HasColumnType("int");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookCount = 0,
                            PublisherName = "Nora Sakavic"
                        },
                        new
                        {
                            Id = 2,
                            BookCount = 0,
                            PublisherName = "Vivat"
                        },
                        new
                        {
                            Id = 3,
                            BookCount = 0,
                            PublisherName = "KSD"
                        },
                        new
                        {
                            Id = 4,
                            BookCount = 0,
                            PublisherName = "KM-BUKS"
                        },
                        new
                        {
                            Id = 5,
                            BookCount = 0,
                            PublisherName = "Laboratory"
                        },
                        new
                        {
                            Id = 6,
                            BookCount = 0,
                            PublisherName = "Educational book - Bohdan"
                        },
                        new
                        {
                            Id = 7,
                            BookCount = 0,
                            PublisherName = "Old Lion Publishing House"
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

            modelBuilder.Entity("BookCart", b =>
                {
                    b.HasOne("DataAccess.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.Book", b =>
                {
                    b.HasOne("DataAccess.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("DataAccess.Entities.Order", b =>
                {
                    b.HasOne("DataAccess.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
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
                    b.HasOne("DataAccess.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccess.Entities.Customer", null)
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

                    b.HasOne("DataAccess.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccess.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DataAccess.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

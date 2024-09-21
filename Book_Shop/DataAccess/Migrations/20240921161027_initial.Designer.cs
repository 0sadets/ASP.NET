﻿// <auto-generated />
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
    [Migration("20240921161027_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "USA",
                            FirstName = "Nora",
                            LastName = "Sakavic"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Ukraine",
                            FirstName = "Hilarion",
                            LastName = "Pavlyuk"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "USA",
                            FirstName = "Erin",
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
                            LastName = "Mann"
                        },
                        new
                        {
                            Id = 6,
                            Biography = "USA",
                            FirstName = "Ray",
                            LastName = "Bradbury"
                        },
                        new
                        {
                            Id = 7,
                            Biography = "USA",
                            FirstName = "Harper",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = 8,
                            Biography = "UK",
                            FirstName = "Charlotte",
                            LastName = "Brontë"
                        },
                        new
                        {
                            Id = 9,
                            Biography = "Ukraine",
                            FirstName = "Grigory",
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
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EBookPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("PaperPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

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
                            ImagePath = "https://static.wikia.nocookie.net/aftg/images/6/6a/%D0%9B%D0%B8%D1%81%D1%8C%D1%8F_%D0%BD%D0%BE%D1%80%D0%B0.jpeg/revision/latest?cb=20231119183605&path-prefix=ru",
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
                            ISBN = "978-5-6044581-3-6",
                            ImagePath = "https://fantasy-worlds.org/img/full/338/33893.jpg",
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
                            ImagePath = "https://fantasy-worlds.org/img/full/339/33978.jpg",
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

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Novel"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Contemporary literature"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Young Adult"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Mystical Horror"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Southern Gothic Bildungsroman"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Fiction"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rivne",
                            Email = "Osadets2004@gmail.com",
                            FirstName = "Sasha",
                            LastName = "Osadets",
                            Phone = "+380958325059"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rivne",
                            Email = "Misha2004@gmail.com",
                            FirstName = "Misha",
                            LastName = "Jobs",
                            Phone = "+380951234059"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Lviv",
                            Email = "levchyk2004@gmail.com",
                            FirstName = "Olena",
                            LastName = "Levchyk",
                            Phone = "+380956543219"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PublisherName = "Nora Sakavic"
                        },
                        new
                        {
                            Id = 2,
                            PublisherName = "Vivat"
                        },
                        new
                        {
                            Id = 3,
                            PublisherName = "KSD"
                        },
                        new
                        {
                            Id = 4,
                            PublisherName = "KM-BUKS"
                        },
                        new
                        {
                            Id = 5,
                            PublisherName = "Laboratory"
                        },
                        new
                        {
                            Id = 6,
                            PublisherName = "Educational book - Bohdan"
                        },
                        new
                        {
                            Id = 7,
                            PublisherName = "Old Lion Publishing House"
                        });
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

            modelBuilder.Entity("DataAccess.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("DataAccess.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

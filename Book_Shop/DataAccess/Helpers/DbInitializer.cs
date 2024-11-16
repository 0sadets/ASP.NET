using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Helpers
{
    public static class DbInitializer
    {
        public static void SeedAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author[]
                {
                    new Author()
                    {
                        Id = 1,
                        FirstName = "Nora",
                        LastName = "Sakavic",
                        Biography = "USA",
                        ImagePath = "https://knigogo.top/wp-content/uploads/2023/01/Nora-Sakavic-237x308.jpg"
					},
                    new Author()
                    {
                        Id = 2,
                        FirstName = "Hilarion",
                        LastName = "Pavlyuk",
                        Biography = "Ukraine",
                        ImagePath = "https://forbes.ua/static/storage/thumbs/414x671/5/1f/7f751b94-b3bb5c9efa73b215c208131abc3a41f5.jpg?v=4355_2"
					},
                    new Author()
                    {
                        Id = 3,
                        FirstName = "Erin",
                        LastName = "Morgenstern",
                        Biography = "USA",
						ImagePath ="https://mybookshelf.com.ua/files/Erin.jpg"

					},
                    new Author()
                    {
                        Id = 4,
                        FirstName = "V.",
                        LastName = "Tsybulska",
                        Biography = "Ukraine",
						ImagePath =null

					},
                    new Author()
                    {
                        Id = 5,
                        FirstName = "Thomas",
                        LastName = "Mann",
                        Biography = "Germany",
						ImagePath ="https://static.yakaboo.ua/media/entity/author/1/_/1_5_2.jpg"

					},
                    new Author()
                    {
                        Id = 6,
                        FirstName = "Ray",
                        LastName = "Bradbury",
                        Biography = "USA",
						ImagePath ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeCIh-DgHkRN6kF01iw5EVC7AMAR8PFbUeNg&s"

					},
                    new Author()
                    {
                        Id = 7,
                        FirstName = "Harper",
                        LastName = "Lee",
                        Biography = "USA",
						ImagePath ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8pdhxKYlV1EYfjGfTf9P-EpF2LGQn8Ev2pg&s"

					},
                    new Author()
                    {
                        Id = 8,
                        FirstName = "Charlotte",
                        LastName = "Brontë",
                        Biography = "UK",
						ImagePath ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtdV2etWBDVg4tdHyaCERfMZNqmPTUMNhJMQ&s"

					},
                    new Author()
                    {
                        Id = 9,
                        FirstName = "Grigory",
                        LastName = "Kvitky-Osnovyanenko",
                        Biography = "Ukraine",
						ImagePath ="https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg/800px-%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg"

					},
                });
        }
        //public static void SeedCustomer(this ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Customer>().HasData(
        //        new Customer[]
        //        {
        //            new Customer()
        //            {
        //                Id = 1,
        //                FirstName = "Sasha",
        //                LastName = "Osadets",
        //                Email = "Osadets2004@gmail.com",
        //               // Phone = "0958325059",
        //                Address = "Rivne",
        //            },
        //            new Customer()
        //            {
        //                Id = 2,
        //                FirstName = "Misha",
        //                LastName = "Jobs",
        //                Email = "Misha2004@gmail.com",
        //               // Phone = "0951234059",
        //                Address = "Rivne",
        //            },
        //            new Customer()
        //            {
        //                Id = 3,
        //                FirstName = "Olena",
        //                LastName = "Levchyk",
        //                Email = "levchyk2004@gmail.com",
        //               // Phone = "0956543219",
        //                Address = "Lviv",
        //            },
        //        });
        //}
        
        public static void SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category()
                    {
                        Id = 1,
                        CategoryName = "Novel",
                    },
                    new Category()
                    {
                        Id = 2,
                        CategoryName = "Contemporary literature",
                    },
                    new Category()
                    {
                        Id = 3,
                        CategoryName = "Young Adult",
                    },
                    new Category()
                    {
                        Id = 4,
                        CategoryName = "Mystical Horror",
                    },
                    new Category()
                    {
                        Id = 5,
                        CategoryName = "Fantasy",
                    },
                    new Category()
                    {
                        Id = 6,
                        CategoryName = "Horror",
                    },
                    new Category()
                    {
                        Id = 7,
                        CategoryName = "Southern Gothic Bildungsroman",
                    },
                    new Category()
                    {
                        Id = 8,
                        CategoryName = "Fiction",
                    },
                });
        }
        public static void SeedPublisher(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher[]
                {
                    new Publisher()
                    {
                        Id = 1,
                        PublisherName = "Nora Sakavic",
                    },
                    new Publisher()
                    {
                        Id = 2,
                        PublisherName = "Vivat",
                    },
                    new Publisher()
                    {
                        Id = 3,
                        PublisherName = "KSD",
                    },
                    new Publisher()
                    {
                        Id = 4,
                        PublisherName = "KM-BUKS",
                    },
                    new Publisher()
                    {
                        Id = 5,
                        PublisherName = "Laboratory",
                    },
                    new Publisher()
                    {
                        Id = 6,
                        PublisherName = "Educational book - Bohdan",
                    },
                    new Publisher()
                    {
                        Id = 7,
                        PublisherName = "Old Lion Publishing House",
                    },

                });
        }
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(

            new Book[]
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Foxhole Court",
                    ISBN = "1516801512",
                    PaperPrice = 570,
                    EBookPrice = 160,
                    Description = "Neil Josten is the newest addition to the Palmetto State University Exy team.",
                    Count = 10,
                    Year = 2013,
                    ImagePath = "https://yabooks.com.ua/content/images/35/311x480l50nn0/49283594893207.jpeg",
                    Language = "English",
                    NumberOfPages = 260,
                    AuthorId = 1,
                    PublisherId = 1,
                    CategoryID = 3,


                },
                new Book()
                {
                    Id = 2,
                    Title = "The Raven King",
                    ISBN = "97856044580",
                    PaperPrice = 590,
                    EBookPrice = 180,
                    Description = "he Foxes are a fractured mess, but their latest disaster might be the miracle they've always needed to come together as a team. The one person standing in their way is Andrew, and the only one who can break through his personal barriers is Neil.",
                    Count = 17,
                    Year = 2013,
                    ImagePath = "https://yabooks.com.ua/content/images/36/311x480l50nn0/94468796443708.jpeg",
                    Language = "English",
                    NumberOfPages = 432,
                    AuthorId = 1,
                    PublisherId = 1,
                    CategoryID = 2,


                },
                 new Book()
                {
                    Id = 3,
                    Title = "The King's Men",
                    ISBN = "9786171701090",
                    PaperPrice = 650,
                    EBookPrice = 280,
                    Description = "He knew when he came to PSU he wouldn't" +
                        " survive the year, but with his death right around the corner he's got more reasons" +
                        " than ever to live. ",
                    Count = 13,
                    Year = 2014,
                    ImagePath = "https://yabooks.com.ua/content/images/37/311x480l50nn0/26706706797137.jpeg",
                    Language = "English",
                    NumberOfPages = 448,
                    AuthorId = 1,
                    PublisherId = 1,
                    CategoryID = 3,


                },
                  new Book()
                {
                    Id = 4,
                    Title = "I see you are interested in the dark",
                    ISBN = "9786176798323",
                    PaperPrice = 450,
                    EBookPrice = 300,
                    Description = "\"I see you are interested in the dark\" is a story" +
                        " about impenetrable human indifference and the darkness within us",
                    Count = 20,
                    Year = 2022,
                    ImagePath = "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/y/a/ya_bachu_vas_cikavytj_pitjma_cover_full.jpg",
                    Language = "Ukrainian",
                    NumberOfPages = 664,
                    AuthorId = 2,
                    PublisherId = 7,
                    CategoryID = 8,


                },
                   new Book()
                {
                    Id = 5,
                    Title = "451° Fahrenheit",
                    ISBN = "9783060311354",
                    PaperPrice = 570,
                    EBookPrice = 160,
                    Description = "Fahrenheit 451 tells the story of Guy" +
                        " Montag and his transformation from a book-burning " +
                        "fireman to a book-reading rebel. ",
                    Count = 24,
                    Year = 1953,
                    ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqDywXlxk7PpGQaNR5B50K-JGw36JBrokCwA&s",
                    Language = "Ukrainian",
                    NumberOfPages = 272,
                    AuthorId = 6,
                    PublisherId = 6,
                    CategoryID = 6,


                },

            });
            
        }
    }
}

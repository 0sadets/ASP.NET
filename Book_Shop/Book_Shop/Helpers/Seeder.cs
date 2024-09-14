using Book_Shop.Models;

namespace Book_Shop.Helpers
{
    public class Seeder
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new Book[]
            {
                new Book()
                {
                    Id = 1,
                    Title = "The Foxhole Court",
                    Description = "Neil Josten is the newest addition to the Palmetto " +
                        "State University Exy team.",
                    Author = "Nora Sakavic",
                    Year = 2013,
                    Publisher = "Nora Sakavic",
                    Price = 420,
                    Genre = "Young Adult",
                    NumberOfPages = 260,
                    ImagePath = "/Images/1.jpg"

                },
                new Book() {
                    Id = 2,
                    Title = "To kill a mockingbird",
                    Description = "Set in small-town Alabama, the novel is a bildungsroman and chronicles the childhood of" +
                        " Scout and Jem Finch as their father Atticus defends a Black man " +
                        "falsely accused of rape. ",
                    Author = "Harper Lee",
                    Year = 1960,
                    Publisher = "KM-BUKS",
                    Price = 400,
                    Genre = "Southern Gothic Bildungsroman",
                    NumberOfPages = 384,
                    ImagePath = "/Images/2.jpg"
                },
                new Book() {
                    Id = 3,
                    Title = "Jane Eyre",
                    Description = "Jane describes herself as, \"poor, obscure, plain and little.\" " +
                        "Mr. Rochester once compliments Jane's \"hazel eyes and hazel hair\"",
                    Author = "Charlotte Brontë",
                    Year = 1847,
                    Publisher = "Nebo Booklab Publishing",
                    Price = 460,
                    Genre = "Gothic Bildungsroman Romance",
                    NumberOfPages = 728,
                    ImagePath = "/Images/3.jpg"
                },
                new Book() {
                    Id = 4,
                    Title = "Konotop Witch",
                    Description = "The story tells about the events in the small town of Konotop",
                    Author = "Grigory Kvitky-Osnovyanenko",
                    Year = 1833,
                    Publisher = "Vivat",
                    Price = 390,
                    Genre = "Satirical story",
                    NumberOfPages = 524,
                    ImagePath = "/Images/4.jpg"
                },
                new Book() {
                    Id = 5,
                    Title = "Starless sea",
                    Description = "Zachary Ezra Rawlins is an ordinary student living on a university campus in Vermont.",
                    Author = "Erin Morgenstern",
                    Year = 2023,
                    Publisher = "Vivat",
                    Price = 230,
                    Genre = "Adventure novel",
                    NumberOfPages = 554,
                    ImagePath = "/Images/5.jpg"
                },
            };
        }
    }
}

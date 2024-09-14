namespace Book_Shop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string Publisher {  get; set; }
        public string Genre {  get; set; }
        public int NumberOfPages {  get; set; }
        public string ImagePath { get; set; }

    }
}

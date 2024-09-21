using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal PaperPrice {  get; set; }
        public decimal EBookPrice {  get; set; }
        public string Description { get; set; }
        public int Count {  get; set; }
        public int Year { get; set; }
        public string ImagePath { get; set; }
        public string Language {  get; set; }
        public int NumberOfPages { get; set; }

        public int AuthorId {  get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}

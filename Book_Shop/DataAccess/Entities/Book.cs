using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Book
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Fild is required"), MinLength(3)]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Fild is required")]
        public string ISBN { get; set; }

        //[Range(0, double.MaxValue, ErrorMessage = "Price must be bigger than 0"), Required]
        public decimal PaperPrice {  get; set; }

        //[Range(0, double.MaxValue, ErrorMessage = "Price must be bigger than 0"), Required]
        public decimal EBookPrice {  get; set; }

        //[Required(ErrorMessage = "Fild is required")]
        public string Description { get; set; }

        //[Range(0, double.MaxValue, ErrorMessage = "Count must be bigger than 0"), Required]
        public int Count {  get; set; }

        //[Range(0, int.MaxValue, ErrorMessage = "Year cannot be negative."), Required]
        public int Year { get; set; }

        //[Url]
        public string? ImagePath { get; set; }

        //[Required]
        public string Language {  get; set; }

        //[Range(0, int.MaxValue, ErrorMessage = "Number of pages cannot be negative."), Required]
        public int NumberOfPages { get; set; }

        public int AuthorId {  get; set; }
        public Author? Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        public ICollection<Cart>? Carts { get; set; }

    }
}

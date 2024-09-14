using Book_Shop.Helpers;
using Book_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book_Shop.Controllers
{
    public class BooksController : Controller
    {
        List<Book> books;
        public BooksController()
        {
            books = new List<Book>(Seeder.GetBooks());
        }
        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult Details(int id) 
        { 
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null) {return NotFound();}
            return View(book);


        }

    }
}

using Book_Shop.Helpers;
using Book_Shop.Models;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Controllers
{
    public class BooksController : Controller
    {
        ShopDbContext DbContext;
        public BooksController()
        {
             DbContext = new ShopDbContext();
        }
        public IActionResult Index()
        {
            return View(DbContext.Books.ToList());
        }
        public IActionResult Details(int id) 
        { 
            if(id<0) { return BadRequest(); }

            var book = DbContext.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .FirstOrDefault(b => b.Id == id);
            if (book == null) {return NotFound();}
            return View(book);


        }

    }
}

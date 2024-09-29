using Book_Shop.Helpers;
using Book_Shop.Models;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Controllers
{
    public class BooksController : Controller
    {
        private readonly ShopDbContext DbContext;
        public BooksController(ShopDbContext context)
        {
             DbContext = context;
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
        // get ~/Books/Create
        public IActionResult Create()
        {
            ViewBag.AuthorList = new SelectList(
                DbContext.Authors
                    .Select(a => new {
                        Id = a.Id,
                        FullName = a.FirstName + " " + a.LastName
                    }).ToList(),
                "Id", "FullName");


            ViewBag.CategoryList = new SelectList (DbContext.Categories.ToList(),
                nameof(Category.Id), nameof(Category.CategoryName));
            ViewBag.PublisherList = new SelectList(DbContext.Publishers.ToList(),
                nameof(Publisher.Id), nameof(Publisher.PublisherName));
            return View();
        }

        // post ~/Books/Create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            DbContext.Books.Add(book);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}

using Book_Shop.Helpers;
using Book_Shop.Models;
using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

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
        public IActionResult Delete(int id)
        {
            var book = DbContext.Books.Find(id);
            if (book == null) return NotFound();
            
            DbContext.Books.Remove(book);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        private void LoadData()
        {
            ViewBag.AuthorList = new SelectList(
                DbContext.Authors
                    .Select(a => new {
                        Id = a.Id,
                        FullName = a.FirstName + " " + a.LastName
                    }).ToList(),
                "Id", "FullName");


            ViewBag.CategoryList = new SelectList(DbContext.Categories.ToList(),
                nameof(Category.Id), nameof(Category.CategoryName));
            ViewBag.PublisherList = new SelectList(DbContext.Publishers.ToList(),
                nameof(Publisher.Id), nameof(Publisher.PublisherName));

        }
        public IActionResult Edit(int id)
        {
            var book = DbContext.Books.Find(id);
            if (book == null) return NotFound();
            LoadData();

            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                LoadData();
                return View(book);
            }

            DbContext.Books.Update(book);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
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
            LoadData();
            return View();
        }

        // post ~/Books/Create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                LoadData();
                return View(book);
            }
            DbContext.Books.Add(book);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}

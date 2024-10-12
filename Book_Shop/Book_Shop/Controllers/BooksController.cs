using Book_Shop.Helpers;
using Book_Shop.Models;
using Book_Shop.Services;
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
        private readonly IBookService service;
        public BooksController(IBookService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetBooks());
        }
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        private void LoadData()
        {
            ViewBag.AuthorList = new SelectList(
                service.GetAuthorList(),
                "Id", "FullName");


            ViewBag.CategoryList = new SelectList(service.GetCategoryList(),
                nameof(Category.Id), nameof(Category.CategoryName));
            ViewBag.PublisherList = new SelectList(service.GetPublisherList(),
                nameof(Publisher.Id), nameof(Publisher.PublisherName));

        }
        public IActionResult Edit(int id)
        {
            var book = service.GetBookById(id);
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

            service.Edit(book);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id) 
        { 
            if(id<0) { return BadRequest(); }

            var book = service.GetBookById(id);
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
            service.Create(book);
            return RedirectToAction(nameof(Index));
        }

    }
}

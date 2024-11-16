using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_Shop.Controllers
{
	public class AuthorController : Controller
	{
		private readonly IAuthorService service;
        private readonly IBookService bookService;

        public AuthorController(IAuthorService service, IBookService bookService)
		{
			this.service = service;
            this.bookService = bookService;
        }
        public IActionResult Index(string searchQuery = null)
        {
            var authors = string.IsNullOrWhiteSpace(searchQuery)
                ? service.GetAuthors()
                : service.SearchAuthors(searchQuery);

            ViewBag.SearchQuery = searchQuery;
            return View(authors);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Remove(int id)
		{
			service.Remove(id);
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Details(int id, string returnUrl = null)
		{
            if (id < 0) { return BadRequest(); }
			ViewBag.Books = service.GetBooks(id);
            var author = service.GetAuthorById(id);
			if (author == null) return NotFound();
			ViewBag.ReturnUrl = returnUrl;
			return View(author);
		}
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Author author)
		{
			if (!ModelState.IsValid)
			{
				return View(author);
			}
			service.Add(author);
			return RedirectToAction(nameof(Index));
		}

	}
}

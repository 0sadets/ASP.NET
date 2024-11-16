using Book_Shop.Models;
using Book_Shop.Services;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Book_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService Service;

        public HomeController(IBookService service)
        {
            Service = service;
        }
        
		public IActionResult Index(int? categoryId = null, int? publisherId = null, string searchQuery = null)
		{
			var books = Service.GetBooks();

			if (categoryId.HasValue)
			{
				books = books.Where(book => book.CategoryID == categoryId.Value).ToList();
			}

			if (publisherId.HasValue)
			{
				books = books.Where(book => book.PublisherId == publisherId.Value).ToList();
			}

			if (!string.IsNullOrWhiteSpace(searchQuery))
			{
				books = books.Where(book => book.Title.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
			}

			ViewBag.SearchQuery = searchQuery;
			ViewBag.CategoryId = categoryId;
			ViewBag.PublisherId = publisherId;// Зберігаємо для можливого відображення у вигляді
			return View(books);
		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

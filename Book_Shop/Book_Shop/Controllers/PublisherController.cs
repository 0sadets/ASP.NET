using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_Shop.Controllers
{
	public class PublisherController : Controller
	{
		private readonly IPublisherService service;
		private readonly IBookService bookService;

		public PublisherController(IPublisherService service, IBookService bookService)
        {
			this.service = service;
			this.bookService = bookService;
		}
        public IActionResult Index(string searchQuery = null)
		{
			var publishers = service.GetAllPublisher();
            foreach (var publisher in publishers)
            {
                publisher.BookCount = bookService.GetBooksByPublisherId(publisher.Id).Count;
            }
            if (!string.IsNullOrEmpty(searchQuery)) 
			{
				publishers = publishers.Where(p=>p.PublisherName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
			}
			ViewBag.SearchQuery = searchQuery;
			return View(publishers);
		}
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
		{
			ViewBag.Publishers = service.GetAllPublisher();
			return View(new Publisher());
		}
		[HttpPost]
		public IActionResult Create(Publisher publisher)
		{
			if (!ModelState.IsValid)
			{
				return View(publisher);
			}
			service.AddPublisher(publisher);
			return RedirectToAction(nameof(Index));
		}
		//public IActionResult GetBooksByPublisher(int id, string returnUrl = null)
		//{
		//	if (id < 0) { return BadRequest(); }
		//	var books = bookService.GetBooksByPublisherId(id);
		//	if (books == null) { return NotFound(); }
		//	ViewBag.ReturnUrl = returnUrl;
		//	return View(books);
		//}
	}
}

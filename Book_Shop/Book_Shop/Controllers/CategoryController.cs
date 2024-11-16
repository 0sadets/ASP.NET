using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Book_Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService service;
		private readonly IBookService bookService;

		public CategoryController(ICategoryService service, IBookService bookService)
        {
            this.service = service;
			this.bookService = bookService;
		}
        public IActionResult Index( string searchQuery = null)
        {
            var categories = service.GetAllCategories();
            foreach (var category in categories)
            {
                category.BookCount = bookService.GetBooksByCategoryId(category.Id).Count;
            }
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                categories = categories.Where(c => c.CategoryName.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            ViewBag.SearchQuery = searchQuery;
            return View(categories);
        }
        //public IActionResult Delete(int id)
        //{
        //    service.DeleteCategoryById(id);
        //    return RedirectToAction(nameof(Index));
        //}
        //public IActionResult Delete(int id)
        //{
        //    var category = service.GetCategoryById(id);
        //    if (category == null)
        //    {
        //        return NotFound(); 
        //    }

        //    if (category.Books != null && category.Books.Any())
        //    {
        //        TempData["ErrorMessage"] = "Cannot delete category because it has associated books."; // Повідомлення про помилку
        //        return RedirectToAction("Create"); 
        //    }

        //    service.DeleteCategoryById(id); 
        //    return RedirectToAction("Create"); 
        //}

        [Authorize(Roles = "Admin")]
        public ActionResult Create() {

			ViewBag.Categories = service.GetAllCategories();
			return View(new Category());
        }
        [HttpPost]
        public IActionResult Create(Category category) 
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            service.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult GetBooksByCategory(int id, string returnUrl = null)
        {
            if (id < 0) { return BadRequest(); }
			var books = bookService.GetBooksByCategoryId(id);
            if(books == null) { return NotFound(); }
			ViewBag.ReturnUrl = returnUrl;
			return View(books);
		}

        //public IActionResult GetCategoryById(int id) 
        //{
        //    service.GetCategoryById(id);
        //    return View();
        //}
    }
}

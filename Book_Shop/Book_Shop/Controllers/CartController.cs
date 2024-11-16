using Book_Shop.Services;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;


namespace Book_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IBookService bookService;

        public CartController(ICartService service, IBookService bookService)
        {
            this.cartService = service;
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            ViewBag.AuthorList = new SelectList(
                bookService.GetAuthorList(),
                "Id", "FullName");
            return View(cartService.GetBooks());
        }
        public IActionResult Add(int bookId, string returnUrl)
        {
            cartService.Add(bookId);
            return Redirect(returnUrl);
        }
        public IActionResult Remove(int bookId, string returnUrl)
        {
            cartService.Remove(bookId);
            return Redirect(returnUrl);
        }
    }
}

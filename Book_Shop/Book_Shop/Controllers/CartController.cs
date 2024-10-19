using Book_Shop.Services;
using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace Book_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        public CartController(ICartService service)
        {
            this.cartService = service;
        }
        public IActionResult Index()
        {
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

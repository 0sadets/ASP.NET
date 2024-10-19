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
        public IActionResult Index()
        {
            return View(Service.GetBooks());
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

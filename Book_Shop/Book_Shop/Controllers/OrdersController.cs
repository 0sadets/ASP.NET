using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Book_Shop.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IMailService mailService;
        private readonly IBookService bookService;

        private string GetUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        private string UserName() => User.FindFirstValue(ClaimTypes.Name)!;

        public OrdersController(IOrderService orderService, IMailService mailService, IBookService bookService)
        {
            this.orderService = orderService;
            this.mailService = mailService;
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            var userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }
            //ViewBag.AuthorList = new SelectList(
            //    bookService.GetAuthorList(),
            //    "Id", "FullName");
            var orders = orderService.GetAll(userId);
            return View(orders);
        }

        public IActionResult Create()
        {
            //create oder
            //id
            //date.now
            //cartService.GetBooks
            //string userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            orderService.Create(GetUserId());
            HttpContext.Session.Remove("cart");
            string body = $@"
                <table align='left' style='width: 100%; font-family: Arial, sans-serif; color: #333; padding: 15px;'>
                    <tr>
                        <td align='left' style='padding: 10px;'>
                            <h3 style='margin: 0; font-size: 18px; color: #333;'>Dear {UserName()},</h3>
                            <p style='margin: 10px 0; font-size: 14px; line-height: 1.6;'>You recently confirmed your book order. </p>
                            <p style='margin: 10px 0; font-size: 14px; line-height: 1.6;'>We just wanted to take a moment to thank you for choosing us for your brain food delivery needs. We hope that you enjoyed the books and the service, and that we met your expectations.</p>
                            <p style='margin: 10px 0; font-size: 14px; line-height: 1.6;'>If there's anything we can do to make your experience even better, please don't hesitate to let us know. We appreciate your feedback and are always looking for ways to improve.</p>
                            <p style='margin: 10px 0; font-size: 14px; line-height: 1.6;'>Thank you again for your business. We look forward to serving you again soon!</p>
                            <p style='margin: 10px 0; font-size: 14px; line-height: 1.6;'>Best regards,<br>Book_Shell Administrator</p>
                        </td>
                    </tr>
                </table>
            ";
            mailService.SendMessageAsync(
                "Book_Shell",
                body,
                "osadets0607@gmail.com"
            );

            return RedirectToAction(nameof(Index));
        }
    }
}

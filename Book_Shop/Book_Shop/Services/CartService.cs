using BusinessLogic.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;


namespace Book_Shop.Services
{
    public class CartService:ICartService
    {
        private readonly IBookService service;
        private readonly HttpContext? httpContext;

        public CartService(IBookService service, IHttpContextAccessor httpContextAccessor)
        {
            this.service = service;
            this.httpContext = httpContextAccessor.HttpContext;
        }

        public void Add(int bookId)
        {
            
            var bookIds = httpContext.Session.GetObject<List<int>>("cart");
            if (bookIds == null)
            {
                bookIds = new List<int>();
            }
            bookIds.Add(bookId);
            httpContext.Session.SetObject("cart", bookIds);
        }

        public List<Book> GetBooks()
        {
            var bookIds = httpContext.Session.GetObject<List<int>>("cart");
            List<Book> books = new List<Book>();

            if (bookIds != null)
            {
                books = service.Get(bookIds.ToArray());
            }
            return books;
        }

        public bool IsInCart(int bookId)
        {
            var bookIds = httpContext.Session.GetObject<List<int>>("cart");
            if(bookIds == null) return false;
            return bookIds.Contains(bookId);

        }

        public void Remove(int bookId)
        {
            var bookIds = httpContext.Session.GetObject<List<int>>("cart");
            if(bookIds == null) { bookIds = new List<int>(); }
            bookIds.Remove(bookId);
            httpContext.Session.SetObject("cart", bookIds);
        }
    }
}

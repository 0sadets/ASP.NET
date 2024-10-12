using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Shop.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();
        List<object> GetAuthorList();
        List<Publisher> GetPublisherList();
        List<Category> GetCategoryList();
        Book? GetBookById(int id);
        void Create(Book book);
        void Edit(Book book);
        void Delete(int id);

    }
    public class BookService : IBookService
    {
        private readonly ShopDbContext _context;
        public BookService(ShopDbContext context) 
        {
            this._context = context;
        }
        public void Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var find = _context.Books.Find(id);
            if (find == null) return;

            _context.Books.Remove(find);
            _context.SaveChanges();
        }
        public void Edit(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }
        public Book? GetBookById(int id)
        {
            if(id<0) return null;
            var book = _context.Books
                .Include(b => b.Author)       // Завантаження даних автора
                .Include(b => b.Publisher)    // Завантаження даних видавця
                .Include(b => b.Category)     // Завантаження даних категорії
                .FirstOrDefault(b => b.Id == id);
            if (book == null) return null;
            return book;
        }
        public List<Category> GetCategoryList() 
        { 
            return _context.Categories.ToList();
        }
        public List<Publisher> GetPublisherList()
        {
            return _context.Publishers.ToList();
        }
        public List<object> GetAuthorList() 
        {
            return _context.Authors
                .Select(x => new
                {
                    Id = x.Id,
                    FullName = x.FirstName + " " + x.LastName

                }).ToList<object>();    
        }
    }
}

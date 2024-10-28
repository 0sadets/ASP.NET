using BusinessLogic.Interfaces;
using DataAccess;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> bookRepo;
        private readonly IRepository<Category> categoryRepo;
        private readonly IRepository<Publisher> publisherRepo;
        private readonly IRepository<Author> authorRepo;

        public BookService(IRepository<Book> bookRepo, IRepository<Category> categoryRepo, IRepository<Publisher> publisherRepo, IRepository<Author> authorRepo)
        {
            this.bookRepo = bookRepo;
            this.categoryRepo = categoryRepo;
            this.publisherRepo = publisherRepo;
            this.authorRepo = authorRepo;
        }
        public void Create(Book book)
        {
            try
            {
                bookRepo.Insert(book);
                bookRepo.Save();
                Console.WriteLine("Книга успішно додана.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час додавання книги: {ex.Message}");
            }
        }
        public void Delete(int id)
        {
            //var find = _context.Books.Find(id);
            //if (find == null) return;

            //_context.Books.Remove(find);
            //_context.SaveChanges();
            var find = GetBookById(id);
            if (find == null) return;

            bookRepo.Delete(find);
            bookRepo.Save();
        }
        public void Edit(Book book)
        {
            //_context.Books.Update(book);
            //_context.SaveChanges();
            bookRepo.Update(book);
            bookRepo.Save();
        }
        public List<Book> GetBooks()
        {
            //return _context.Books.ToList();
            return bookRepo.Get().ToList();
        }
        public Book? GetBookById(int id)
        {
            //if(id<0) return null;
            //var book = _context.Books
            //    .Include(b => b.Author)       // Завантаження даних автора
            //    .Include(b => b.Publisher)    // Завантаження даних видавця
            //    .Include(b => b.Category)     // Завантаження даних категорії
            //    .FirstOrDefault(b => b.Id == id);
            //if (book == null) return null;
            //return book;

            if (id < 0) return null;

            var book = bookRepo.Get(
                filter: b => b.Id == id,
                includeProperties: new[] { "Author", "Publisher", "Category" }
            ).FirstOrDefault();

            return book;
        }
        public List<Category> GetCategoryList()
        {
            //return _context.Categories.ToList();
            return categoryRepo.Get().ToList();
        }
        public List<Publisher> GetPublisherList()
        {
            //return _context.Publishers.ToList();
            return publisherRepo.Get().ToList();
        }
        public List<object> GetAuthorList()
        {
            //return _context.Authors
            //    .Select(x => new
            //    {
            //        Id = x.Id,
            //        FullName = x.FirstName + " " + x.LastName

            //    }).ToList<object>();    
            return authorRepo.Get()
                .Select(x => new
                {
                    Id = x.Id,
                    FullName = x.FirstName + " " + x.LastName
                })
                .ToList<object>();
        }

        public List<Book> Get(int[] ids)
        {
            //return _context.Books.Where(
            //    b => ids.Contains(b.Id)).ToList();
            return bookRepo.Get(b => ids.Contains(b.Id)).ToList();
        }
    }
}

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

            if (id < 0) return null;

            var book = bookRepo.Get(
                filter: b => b.Id == id,
                includeProperties: new[] { "Author", "Publisher", "Category" }
            ).FirstOrDefault();

            return book;
        }
        public List<Category> GetCategoryList()
        {
            return categoryRepo.Get().ToList();
        }
        public List<Publisher> GetPublisherList()
        {
            return publisherRepo.Get().ToList();
        }
        public List<object> GetAuthorList()
        {   
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
            return bookRepo.Get(b => ids.Contains(b.Id)).ToList();
        }

        public List<Book> SearchBooks(string query)
        {
			if (string.IsNullOrEmpty(query)) return bookRepo.Get().ToList();

			var normilizedQuery = query.ToLowerInvariant();

            return bookRepo.Get()
                .Where(b => b.Title != null && b.Title.ToLower().Contains(normilizedQuery))
                .ToList();
        }

		public List<Book> GetBooksByCategoryId(int id)
		{
			return bookRepo.Get()
                .Where (b => b.CategoryID == id).ToList();
		}
		public List<Book> GetBooksByPublisherId(int id)
		{
			return bookRepo.Get()
				.Where(b => b.PublisherId == id).ToList();
		}

	}
}

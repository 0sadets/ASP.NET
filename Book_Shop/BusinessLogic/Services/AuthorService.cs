using BusinessLogic.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> authorRepo;
        private readonly IRepository<Book> bookRepo;

        public AuthorService(IRepository<Author> authorRepo, IRepository<Book> bookRepo)
        {
            this.authorRepo = authorRepo;
            this.bookRepo = bookRepo;
        }
        public void Add(Author author)
        {
            authorRepo.Insert(author);
            authorRepo.Save();

        }
        public void Edit(Author author)
        {
            authorRepo.Update(author);
            authorRepo.Save();
        }

        public Author? GetAuthorById(int authorId)
        {
            if(authorId == 0) return null;
            return authorRepo.GetById(authorId);
        }

        public List<Author> GetAuthors()
        {
            return authorRepo.Get().ToList();
        }

        public List<Book> GetBooks(int authorId)
        {
            return bookRepo.Get()
                .Where(b=> b.AuthorId == authorId).ToList();
        }

        public void Remove(int authorId)
        {
            var books = bookRepo.Get(b => b.AuthorId == authorId).ToList();

            foreach (var book in books)
            {
                bookRepo.Delete(book);
            }
            bookRepo.Save(); 

            var author = authorRepo.GetById(authorId);
            if (author != null)
            {
                authorRepo.Delete(author);
                authorRepo.Save();
            }
        }
        public List<Author> SearchAuthors(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return authorRepo.Get().ToList();

            // Приводимо запит до нижнього регістру
            var normalizedQuery = query.ToLower();

            // Розділяємо запит на частини
            var queryParts = normalizedQuery.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return authorRepo.Get()
                .Where(a => queryParts.All(part =>
                    (a.FirstName != null && a.FirstName.ToLower().Contains(part)) ||
                    (a.LastName != null && a.LastName.ToLower().Contains(part)) 
                ))
                .ToList();
        }

    }
}

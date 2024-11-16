using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAuthorService
    {
        List<Book> GetBooks(int authorId);
        List<Author> GetAuthors();
        void Add(Author author);
        void Remove(int authorId);
        void Edit(Author author);
        Author? GetAuthorById(int authorId);
        List<Author> SearchAuthors(string query);
    }
}

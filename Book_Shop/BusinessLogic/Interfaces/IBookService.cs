using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IBookService
    {
        List<Book> GetBooks();
        List<Book> Get(int[] ids);
        List<object> GetAuthorList();
        List<Publisher> GetPublisherList();
        List<Category> GetCategoryList();
        Book? GetBookById(int id);
        void Create(Book book);
        void Edit(Book book);
        void Delete(int id);
        List<Book> SearchBooks(string query);
		List<Book> GetBooksByCategoryId(int id);
		List<Book> GetBooksByPublisherId(int id);


	}
}

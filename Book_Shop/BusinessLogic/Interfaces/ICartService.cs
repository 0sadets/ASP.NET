using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICartService
    {
        List<Book> GetBooks();
        void Add(int bookId);
        void Remove(int bookId);
        bool IsInCart(int bookId);
    }
}

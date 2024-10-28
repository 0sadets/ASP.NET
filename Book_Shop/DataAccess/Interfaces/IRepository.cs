using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IRepository<TEntity > where TEntity : class
    {
        // CRUD operation 

        IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           params string[] includeProperties);

        //IEnumerable<Book> GetBooks();
        TEntity GetById(object id);
        void Insert(TEntity entity); // create
        void Update(TEntity entityToUpdate);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Save();

    }
}

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
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> categoryRepo;

        public CategoryService(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        public void AddCategory(Category category)
        {
            categoryRepo.Insert(category);
            categoryRepo.Save();
            Console.WriteLine("категорiя успiшно додана.");

        }

        //public void DeleteCategoryById(int id)
        //{
        //    var find = GetCategoryById(id);
        //    if (find == null) return;
        //    if (find.Books != null) 
        //    {
        //        return;
        //    }

        //    categoryRepo.Delete(find);
        //    categoryRepo.Save();
        //}

        public List<Category> GetAllCategories()
        {
            return categoryRepo.Get().ToList();
        }

        public Category? GetCategoryById(int id)
        {
            if (id == 0) return null;
            return categoryRepo.GetById(id);
        }
    }
}

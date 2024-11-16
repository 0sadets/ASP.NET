using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
	public interface ICategoryService
	{

		void AddCategory(Category category);
		List<Category> GetAllCategories();
		Category? GetCategoryById(int id);
		//void DeleteCategoryById(int id);
		

	}
}

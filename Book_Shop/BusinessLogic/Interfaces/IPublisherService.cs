using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
	public  interface IPublisherService
	{
		void AddPublisher(Publisher publisher);
		List<Publisher> GetAllPublisher();
		Publisher? GetPublisherById(int id);
	}
}

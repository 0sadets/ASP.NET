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
	public class PublisherService : IPublisherService
	{
		private readonly IRepository<Publisher> publRepo;

		public PublisherService(IRepository<Publisher> publRepo)
        {
			this.publRepo = publRepo;
		}
        public void AddPublisher(Publisher publisher)
		{
			publRepo.Insert(publisher);
			publRepo.Save();
			Console.WriteLine("категорiя успiшно додана.");
		}

		public List<Publisher> GetAllPublisher()
		{
			return publRepo.Get().ToList();
		}

		public Publisher? GetPublisherById(int id)
		{
			if (id == 0) return null;
			return publRepo.GetById(id);
		}
	}
}

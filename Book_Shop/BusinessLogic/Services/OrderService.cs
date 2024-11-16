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
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> orderRepo;
        private readonly ICartService cartService;

        public OrderService(IRepository<Order> orderRepo, ICartService cartService)
        {
            this.orderRepo = orderRepo;
            this.cartService = cartService;
        }
        public void Create(string userId)
        {
            var order = new Order()
            {
                Date = DateTime.Now,
                CustomerId = userId,
                Total = cartService.GetBooks().Sum(p => p.PaperPrice)
            };
            orderRepo.Insert(order);
            orderRepo.Save();
        }

        public IEnumerable<Order> GetAll(string userId)
        {
            return orderRepo.Get(o => o.CustomerId == userId);
        }

    }
}

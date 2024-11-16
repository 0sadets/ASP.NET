using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll(string userId);
        void Create(string userId);

    }
}

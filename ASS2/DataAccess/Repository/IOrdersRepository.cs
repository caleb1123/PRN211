using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataAccess.Repository
{
    public interface IOrdersRepository
    {
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetOrderDetailById(int orderDetailId);
        IEnumerable<OrderDetail> GetAllOrderDetails();
        void AddOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderDetailId);
    }
}

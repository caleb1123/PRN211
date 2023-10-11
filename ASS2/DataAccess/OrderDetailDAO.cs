using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        private SaleManageDBContext context = new SaleManageDBContext();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return context.OrderDetails.ToList();
        }

        public OrderDetail GetOrderbyid(int id) 
        {
            return context.OrderDetails.Single(c => c.Orderid == id);
        }
        public void addOrderDetail (OrderDetail order)
        {
            OrderDetail order1 = GetOrderbyid(order.Orderid);
            if(order1 == null)
            {
                context.OrderDetails.Add(order);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("OrderDetail does exists");
            }
        }
        public void removeOrderDetail (int id)
        {
            OrderDetail order = GetOrderbyid(id);
            if(order != null)
            {
                context.OrderDetails.Remove(order); 
                context.SaveChanges();
            }
        }
    }
}

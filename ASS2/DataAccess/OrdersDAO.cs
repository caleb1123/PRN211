using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrdersDAO
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

        public Order GetOrderbyID(int ID)
        {
            return context.Orders.Single(c => c.Orderid == ID);
        }

        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }
        public void AddOrder (Order order)
        {
            Order order1 = GetOrderbyID(order.Orderid);
            if(order1 == null)
            {
                context.Orders.Add(order1);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Order does exists");
            }
        }

        public void RemoveOrder (Order order)
        {
            Order order1 = GetOrderbyID (order.Orderid);
            if(order1 != null)
            {
                context.Orders.Remove(order1);
                context.SaveChanges();
            }
            else 
            {
                throw new Exception("Order does not exists");
            }
        }

        public void UpdateOrder(Order order)
        {
            var m = GetOrders();
            if(m !=null) 
            {
                Order order1 = GetOrderbyID(order.Orderid);
                if(order1 != null)
                {
                    order1.MemberId = order.MemberId;
                    order1.OrderDate = order.OrderDate;
                    order1.RequiredDate = order.RequiredDate;
                    order1.ShippedDate = order.ShippedDate;
                    order1.Freight = order.Freight;
                    context.SaveChanges ();
                }
            }
            else
            {

            }

        }
    }
}

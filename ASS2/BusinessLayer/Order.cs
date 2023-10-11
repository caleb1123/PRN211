using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class Order
    {
        public Order() 
        {
            OrderDetail = new HashSet<OrderDetail>();
        }
        public int Orderid { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate {  get; set; }
        public DateTime ShippedDate { get; set; }
        public decimal Freight { get; set; }

        public virtual Member Member { get; set; }= null;

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

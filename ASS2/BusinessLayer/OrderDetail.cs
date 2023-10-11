using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class OrderDetail
    {
        public int Orderid {  get; set; }
        public int Productid { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Orders { get; set; }=null;
        public virtual Product Product { get; set; } = null;

    }
}

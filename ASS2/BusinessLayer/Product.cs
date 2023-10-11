using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public partial class Product
    {
        public Product() 
        {
            OrderDetail = new HashSet<OrderDetail>();
            
        }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public String ProductName { get; set; }
        public String Weight { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsStock { get; set; }

         
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

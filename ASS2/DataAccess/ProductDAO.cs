using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
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

        public List<Product> GetAllProds() 
        {
            return context.Products.ToList();
        }

        public Product GetProductbyid(int id)
        {
            return context.Products.SingleOrDefault(c => c.ProductId == id);
        }


        public void addProduct(Product product)
        {
            Product product1 = GetProductbyid (product.ProductId);
            if(product1 == null)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Product does exists");
            }
        }

        public void removeProduct(int id)
        {
            Product product = GetProductbyid (id);
            if(product != null)
            {
                context.Products.Remove(product);
            }
            else { throw new Exception("Product does not exists"); }
        }

        public void UpdateProduct(Product product)
        {
            var m = GetAllProds();
            if(product != null)
            {
                Product product1 = GetProductbyid ((int)product.ProductId);
                if(product1 != null)
                {
                    product1.ProductName = product.ProductName;
                    
                }
            }
        }
    }
}

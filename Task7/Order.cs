using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Order
    {
        public static List<Product> Products { get; private set; }
        public static Customer Customer { get; private set; }
        public static decimal TotalPrice { get; private set; }


        public Order(List<Product> products, Customer customer)
        {
            Products = products;
            Customer = customer;
            TotalPrice = Products.Sum(p => p.Price);
        }

        public void AddProductInOrder(Product product)
        {
            Products.Add(product);
        }
    }
}

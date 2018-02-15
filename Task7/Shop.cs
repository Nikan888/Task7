using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Shop
    {
        public List<Product> Products { get; private set; }

        public List<Order> Orders { get; private set; }

        public Shop()
        {

        }

        public Shop(List<Product> products)
        {
            Products = products;
        }

        public void AddOrder(List<Product> list, Customer customer)
        {
            Orders.Add(new Order(list, customer));
        }

        public void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

        public void OutputProducts()
        {
            Console.WriteLine("All products:");
            foreach (var prod in Products)
            {
                Console.WriteLine(prod);
            }
        }

        public void OutputOrders()
        {
            Console.WriteLine("All orders:");
            foreach (var order in Orders)
            {
                Console.WriteLine(order);
            }
        }

        public void Pay()
        {
            if (Order.Customer.CurrentSum >= Order.TotalPrice)
            {
                Order.Customer.CurrentSum -= Order.TotalPrice;
                Orders.Clear();
                Console.WriteLine("Payment completed");
            }
            else Console.WriteLine("Customer doesn't have enough money");
        }
    }
}

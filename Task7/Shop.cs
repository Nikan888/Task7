using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Shop
    {
        public static List<Product> Products { get; private set; }

        public static List<Order> Orders { get; private set; }

        public Shop()
        {

        }

        public Shop(List<Product> products)
        {
            Products = products;
        }

        public static void AddOrder(List<Product> list, Customer customer)
        {
            Orders.Add(new Order(list, customer));
        }

        public static void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }

        public static void OutputProducts()
        {
            Console.WriteLine("All products:");
            foreach (var prod in Products)
            {
                Console.WriteLine(prod);
            }
        }

        public static void OutputOrders()
        {
            Console.WriteLine("All orders:");
            foreach (var order in Orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void Pay()
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

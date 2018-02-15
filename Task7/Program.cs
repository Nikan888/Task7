using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Vladislav", 400);

            List<Product> products = new List<Product>
            {
                new Product("Headphones", "Sony", 25),
                new Product("Mouse", "Steelseries", 80),
                new Product("Tequila", "TOBACCO", 33),
                new Product("Cigarettes", "Pall Mall", 2),
                new Product("Laptop", "Lenovo", 184),
                new Product("SSD", "Samsung", 150)
            };

            Shop shop = new Shop(products);

            shop.OutputProducts();
            bool exit = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1. Make order");
                Console.WriteLine("2. Show all orders");
                Console.WriteLine("3. Delete order");
                Console.WriteLine("4. Show customer's money");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Exit");
                int number = 0;
                do
                {
                    var num = Console.ReadLine();
                    if (int.TryParse(num, out number))
                    {
                        if (number < 1 || number > 7)
                            Console.WriteLine("Input menu item is not exist. " +
                                "Input value must be from 1 to 6");
                    }
                    else
                        Console.WriteLine("Number must be int32. Please try again.");
                } while (number < 1 || number > 7);
                switch (number)
                {
                    case 1:
                        shop.AddOrder(products, customer);
                        break;
                    case 2:
                        shop.OutputOrders();
                        break;
                    case 3:
                        Console.WriteLine("Choose number of order");
                        int n = 0;
                        do
                        {
                            var num = Console.ReadLine();
                            if (int.TryParse(num, out n))
                            {
                                if (n < 1 || n > 7)
                                    Console.WriteLine("Input menu item is not exist. " +
                                        "Input value must be from 1 to " + shop.Orders.Count);
                            }
                            else
                                Console.WriteLine("Number must be int32. Please try again.");
                        } while (n < 1 || n > shop.Orders.Count);
                        shop.RemoveOrder(shop.Orders[n]);
                        Console.WriteLine("Order deleted");
                        break;
                    case 4:
                        Console.WriteLine(customer.CurrentSum);
                        break;
                    case 5:
                        shop.Pay();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input of menu item. Try again");
                        break;
                }
            } while (exit != true);
        }
    }
}

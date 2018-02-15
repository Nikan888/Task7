using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Product
    {
        string name;
        string manufacturer;
        decimal price;

        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price must be more than 0");
                }
                price = value;
            }
        }

        public Product(string name, string manufacturer, decimal price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string ToString()
        {
            return (Name + ';' + Manufacturer + ';' + Price);
        }
    }
}

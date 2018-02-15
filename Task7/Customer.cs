using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Customer
    {
        string customerName;
        decimal account;

        public string CustomerName { get => customerName; set => customerName = value; }

        public decimal CurrentSum
        {
            get
            {
                return account;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Account must be more than 0");
                }
                account = value;
            }
        }

        public Customer(string name, int sum)
        {
            CustomerName = name;
            CurrentSum = sum;
        }

        public override string ToString()
        {
            return (CustomerName + ';' + CurrentSum);
        }
    }
}

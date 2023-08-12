using CustomerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(101, "Name1", "name1@yahoo.com", 10);
            Customer customer2 = new Customer(102, "Name2", "name2@gmail.com", 15);

            Customer[] customers =
            {
                customer1,
                customer2,
                new Customer(103, "Name3", "name3@gmail.com"),
                new Customer(104, "Name4", "name4@gmail.com", 25)
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ShowCustomerDetails());
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine($"Customer with Maximum Orders: " +
                $"{Customer.GetCustomerNameWithMaxOrders(customers)}");
            Console.WriteLine("---------------------------------------------");
            Customer customerObject = Customer.GetCustomerDetailsWithMinOrder(customers);
            Console.WriteLine($"Details of Customer with Minimum Orders: " +
                $"\n{customerObject.ShowCustomerDetails()}");
            /*Console.WriteLine($"Details of Customer with Minimum Orders: " +
                $"\n{Customer.GetCustomerDetailsWithMinOrder(customers).ShowCustomerDetails()}");*/


        }
    }
}

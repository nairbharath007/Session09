using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int CountOrder { get; set; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public Customer(int id, string name, string email, int orders) : this(id, name, email)
        {
            CountOrder = orders;
        }

        public string ShowCustomerDetails()
        {
            return $"Id: {Id}\nName: {Name}\nEmail: {Email}\nOrders: {CountOrder}";
        }

        public static string GetCustomerNameWithMaxOrders(Customer[] customers)
        {
            int maxOrders = customers[0].CountOrder; //10
            string name = string.Empty;
            for (int i = 1; i < customers.Length; i++)
            {
                if (customers[i].CountOrder > maxOrders)
                {
                    maxOrders = customers[i].CountOrder;
                    name = customers[i].Name;
                }
            }
            return name;
        }
        public static Customer GetCustomerDetailsWithMinOrder(Customer[] customers)
        {
            Customer customer = null;
            int minOrder = customers[0].CountOrder;

            for (int i = 1; i < customers.Length; i++)
            {
                if (customers[i].CountOrder < minOrder)
                {
                    minOrder = customers[i].CountOrder;
                    customer = customers[i];
                }
            }
            return customer;
        }
    }
}

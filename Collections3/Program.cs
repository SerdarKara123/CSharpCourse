using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            //string tanımladığımız için rakam veremeyiz.
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 5, FirstName = "Serdar" });
            //customers.Add(new Customer { Id = 10, FirstName = "Adem" });
            //yukarıda kısımın diğer yazılım şekli de aşağıdaki gibidir.
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=5, FirstName="Serdar"},
                new Customer{Id=10, FirstName="Adem"}
            };


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

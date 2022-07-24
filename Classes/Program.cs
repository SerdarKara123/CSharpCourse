using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            // clas oluşturulurken pascal keys , örneği oluşturulurken camel keys kullanılır.

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Serdar";
            customer.LastName = "KARA";
            customer.Id = 1986;

           // yukarıdaki ve aşağıdaki customer classlarının arasında kullanım açısından fark yoktur, aynıdır ikiside.
            
            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Muhammed", LastName = "Karaca"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();

        }
    }
}

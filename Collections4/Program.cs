using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            //string tanımladığımız için rakam veremeyiz.
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara")); //şehirlerin içinde Ankara değeri varsa true yoksa false verir.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, FirstName="Serdar"},
                new Customer{Id=2, FirstName="Adem"}
            };

            //customers.Clear();//listeyi temizlemek için kullanılır.

               
            var customer2 = new Customer
            {
                Id=3, FirstName ="Salih" 
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]//elimizdeki listeye yeni eklenecek veriler varsa bu şekilde eklenir.AddRangenin kullanıldığı satırdaki gibi.
            {
                new Customer{Id=4, FirstName="Ali"},
                new Customer{Id=5, FirstName = "Ayşe"}
            });
            Console.WriteLine(customers.Contains(customer2));

            var index = customers.IndexOf(customer2);//elemanın listede kaçıncı olduğunu verir.
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer2);//aramaya sondan başlar.
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0,customer2);//kaçıncı sıraya neyin eklenmesi gerekiyorsa o işlemi yapar.

            //customers.Remove(customer2);//listede aynı elemandan varsa ilk bulduğunu siler.
            customers.RemoveAll(c=>c.FirstName=="Salih");//listede Salihleri bul ve sil işlemini yapar.




            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;//count eleman sayısını verir.
            Console.WriteLine("Count : {0}", count);
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}



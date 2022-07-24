using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.List();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        //bu kısım constructors ların overloading i oluyor.
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added {0} items", _count);
        }
    }

   

}
// yapıcı bloklar = constructors
// ctor iki kere tab ile constructor oluşturulur.
//int _count iki kere tab
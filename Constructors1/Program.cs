using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2,"Computer");
            product.List();

            Console.ReadLine();
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void List()
        {
            Console.WriteLine("Listed product name is Laptop");
        }

    }
}

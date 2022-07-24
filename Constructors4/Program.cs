using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 10;
            Utilities.Validate();
            
            Manager.DoSomething();
            //static kısım böyle çağrılır.

            Manager manager = new Manager();
            manager.DoSomething2();
            //static olmayan kısımda daha önceki gibi newlenerek çağrılır.
           
            Console.ReadLine();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }

}
//static nesneler new lenemez.biri için değişen bir değer diğerleri içinde değişmesi isteniyorsa static nesneler kullanılır.
//class static ise içindeki metotlarda static olmak zorundadır.
//class static değilse içine static metot koyuladabilir, koyulmayadabilir.
//static class içinde static constructors tanımlanabilir.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static int Add(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}     // ()bu parametlerin yazıldığı kısım.

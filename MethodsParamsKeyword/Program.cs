using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5 * 8 * 9 * 10));
            Console.ReadLine();
        }
        static int Add(params  int[] numbers)
        {
            return numbers.Sum();
        }
    }// params metodun parametrelerinin son parametresi olmak zorundadır.
    // params ile birçok sayının işlemi gerçekleştirilebilir.
}

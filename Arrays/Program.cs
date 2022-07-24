using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        } 
    }
}
    //foreach döngüsü bir diziyi gezmek için kullanılır.

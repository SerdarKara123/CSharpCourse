using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Engin, Derin, Salih" };
            
            string[] students2 = { "Engin, Derin, Salih" };
            
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.ReadLine();
        } 
    } 
}// ileride görülecek olan koleksiyonlar konusu arrayların geliştirilmiş versiyonlarıdır.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5,3]
            {
                {"İstanbul", "Bursa", "Çanakkale" },
                {"Ankara", "Eskişehir", "Kayseri" },
                {"Antalya", "Adana", "Mersin" },
                {"Rize", "Trabzon", "Bartın" },
                {"İzmir", "Manisa", "Aydın" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();
        }
    }
}
// [] = tek boyutlu, [,] = iki boyutlu
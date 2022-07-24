using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu veri tiplerinin hepsi değer tipleridir.
            //long integer'dan daha büyük sayıları tutar.
            //Console.WriteLine("Hello World!");
            //short integer'dan küçük sayıları tutar.
            //byte 0 ile 255 arasındaki sayıları tutar. Bu veri tiplerindeki kullanım amacı kapladıkları alanlara göre değişmeleridir.
            //bool veri tipi true ya da false tutar.
            //char veri tipi klavyedeki bütün karakterleri tutar. Sayısal karşılığını da int yazılarak tutulabilir.
            //double veri tipi ondalıklı sayıları tutar.
            //decimal veri tipi double'dan daha yüksek ondalıklı sayıları tutar.Yalnız ondalık sonu küçük veya büyük m harfi koymak gerekir. tam sayılarıda tutar.
            //enum veri tipi metinsel ifadeleri tutar.Enum sabitlerinin değerleri 0 dan başlar ve sayısal karşılıkları int ile tutulabilir.Farklı değerlerde verilebilir.
            //var keyword'u değişken tutmak için kullanılır. İnt olarak atanırsa öyle devam eder ve metinssel olarak tutulmaz.
            var number7 = 10;
            number7 = 'A';
            decimal number6 = 10.34984898390845m;
            double number5 = 10.32;
            char character = 'A';
            bool condition = true;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = 32767;
            byte number4 = 255;
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}

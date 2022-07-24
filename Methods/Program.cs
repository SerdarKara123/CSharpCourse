using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            var result = Add2(20,30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1=20, int number2=30)
        {
            var result = number1 + number2;
            return result;
        }
        // default parametrelerle çalışırken static int Add2(int number1, int number2=30) değeri verilerek de hesaplama yapılabilir.
        //Yukarıda tek değer olsa bile number2 ye satır içinde değer atanırsa uygulama çalışır.default değerler metotdun sonunda olur.
        // Ayrıca number2 'ya değer atnamazsa default değer olarak (int number2 =30) 30'u kullan demek.
        //'void' git şunu yap , şunu yaz veya kayıt yap demek.
        //var result = Add2(20,30); buraya yazılarak da toplanıyor, static int Add2(int number1=20, int number2=30) bu şekilde de değer verilip toplanabiliyor.
    }
}

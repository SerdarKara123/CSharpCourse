using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();//bir anahtarla değere ulaşmayı hedeflediğimiz ortamlarda kullanılır.
            dictionary.Add("book","kitap");
            dictionary.Add("table","tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]); kelimenin karşılığını yazdırmak için bu satır kullanılır.

            //foreach ile de gezilebiliyor.

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);  //item.Key ya da item.Value yazılarak ikisinede ulaşılabilir. 
                                              //sadece item de ise ikisine aynı anda ulaşılır.
            }

            Console.WriteLine(dictionary.ContainsKey("glass")); //glass değeri var mı demek ve alınan cevap false olur. çünkü dictionary içinde glass tanımlamadık.
            Console.WriteLine(dictionary.ContainsKey("table")); // table değerini tanımladığımız için alınan cevap true dir. ContainKey bool dur.
            Console.ReadLine();                                 //ContainsValue de de aynı şekilde ama türkçe karşılıkları aratmak için kullanılır.   
        }
    }
}

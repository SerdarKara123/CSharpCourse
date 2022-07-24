using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Serdar Adem Kara";

            var result = sentence.Length;
            //cümlenin kaç karakterden oluştuğunu verir.Boşluklarda bir karakterdir.
            var result2 = sentence.Clone();
            //cümlenin bir referansını daha oluşturur.
            bool result3 = sentence.EndsWith("a");
            //cümle yazılan harf ile bitiyor mu ? demek.
            bool result4 = sentence.StartsWith("My name");
            //cümle yazılan harf ya da kelime ile başlıyor mu ? demek.
            var result5 = sentence.IndexOf("name");
            //cümlede aranılan kelime ya da harf kaçıncı karakterden başladığını söyler.
            var result6 = sentence.IndexOf(" ");
            //cümledeki ilk boşluğun kaçıncı karakterde olduğunu söyler.
            var result7 = sentence.LastIndexOf(" ");
            //cümlede sondaki boşluğun kaçıncı karakterde olduğunu söyler.
            var result8 = sentence.Insert(0,"Hello, ");
            // 0. karakterden itibaren Hello ile başla demek. Cümle aralarına da ekleme yapılabilir sayı arttırılarak.
            var result9 = sentence.Substring(3);
            //cümlede 3. karakterden itibaren cümleyi al öncesini alma demek.(3,4) bu da 3. karakterden itibaren 4 tane karakter al demek.
            var result10 = sentence.ToLower();
            //cümledeki bütün harfleri küçük harfe çevirir.
            var result11 = sentence.ToUpper();
            //cümledeki bütün harfleri büyük harfe çevirir.
            var result12 = sentence.Replace(" ", "-");
            //belli karakterleri değiştirmek için kullanılır. Örnekte boşluk yerine çizgi kullanılması tanımlanıyor.
            var result13 = sentence.Remove(2,5);
            //cümlede belli bir karakterden sonrasını atmak için kullanılır.



                
            
            
            
            Console.WriteLine(result11);
            Console.ReadLine();
        }
    }
}

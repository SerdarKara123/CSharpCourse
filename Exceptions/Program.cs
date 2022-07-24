using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3]
            {
                "Engin","Derin","Salih"
            };

                students[3] = "Ahmet";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            

            Console.ReadLine();
        }
    }
}
//Hata Yönetimi. Yukarıdaki Ahmet isminin eklenmesinde 3 olarak yazılması hatadır. Çünkü String arrayinde zaten 3 tane öğrenci tanımlı.
//arraylarda sıralama 0 dan başlar ve 0,1,2 şeklinde devam eder.Uygulamadaki hata son kullanıcıya gösterilmez.
//hatanın olduğunda şüphelenilen kod satırı try bloğunun içine atılır . çalıştırıldıktan sonra hata var ise cath bloğuna geçer.
//exception.InnerException varsa hata hakkında daha detaylı bilgi verir.
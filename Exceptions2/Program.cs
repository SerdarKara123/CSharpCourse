using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            //yukarıdaki kod bloğu yerine aşağıdaki kullanım daha pratik bir kullanımdır.

            HandleException(() =>      //delege denilen yapı mevcut burada.
            {
                Find();
            });
            

            Console.ReadLine();
        }


        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }



        private static void Find()//Find metodu haline getirdik.
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))//eğer öğrencilerin içerisinde Ahmet var ise demek.başına ! işareti ile yazarsak da yoksa demektir.
            {
                throw new RecordNotFoundException ("Record Not Found");//bu satır hata fırlat demek
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}

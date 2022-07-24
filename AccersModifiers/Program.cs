using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// AccesModifiers = Erişim bildirgeçleri demektir.
// private değişkenler sadece tanımlandıkları blok(sınıf) içerisinde geçerli olan yapıdır.
//protected private gibi tanımlandıkları blok içerisinde kullanılırlar.
//protected private den tek farkı inheritance yapılan yerlerde protected kullanılabilir.
//bir class ın default u internal dır. internal lar bağlı bulunduğu proje içerisinde referance olmadan kullanılabilir.
//public ler ise referance verildiği zaman başka projelerde de kullanılabilir.
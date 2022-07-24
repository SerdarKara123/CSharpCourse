using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    public class RecordNotFoundException:Exception
    {
        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}
//bir listedeki kayıt bulunamadığında kullanılır.kendi hata mesajımızı oluşturmak için kullanılır.

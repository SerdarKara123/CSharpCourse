using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler gibi abctractclasses larda new lenemiyor.
            DataBase dataBase = new Oracle();
            dataBase.Add();
            dataBase.Delete();

            DataBase dataBase2 = new SqlServer();
            dataBase2.Add();
            dataBase2.Delete();

            Console.ReadLine();
        }
    }

    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
        // abstract classlar ile hem tamamlanmış metotlar hem de tamamlanmamış metotlar yapılabilir.
    }

    class SqlServer : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}

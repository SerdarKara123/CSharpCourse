using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerICustomerDal());
            //customerManager.Add(new OracleICustomerDal());
            //customerManager.Add(new MySqlICustomerDal());


            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerICustomerDal(),
                new OracleICustomerDal(),
                new MySqlICustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }
}

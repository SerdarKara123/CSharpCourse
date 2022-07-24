using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNotes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("one", "bir");
            dictionary.Add("two","iki");
            dictionary.Add("three","üç");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("four"));
            Console.WriteLine(dictionary["three"]);
            Console.ReadLine();
        }
    }

}

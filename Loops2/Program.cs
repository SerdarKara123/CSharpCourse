﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=0);
            Console.ReadLine();
        }
    }
}

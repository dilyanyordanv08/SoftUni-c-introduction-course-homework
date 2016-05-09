﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstFib = 1;
            int secondFib = 1;

            for (int cnt = 2; cnt <= n; cnt++)
            {
                int result = firstFib + secondFib;
                firstFib = secondFib;
                secondFib = result;

            }
            Console.WriteLine(secondFib);
            

        }
    }
}

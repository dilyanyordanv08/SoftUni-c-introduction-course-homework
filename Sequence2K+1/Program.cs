﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var num = 1;
           

            for (int i = 0; i <= n; i ++)
            {
                if (num <= n)
                {
                    Console.WriteLine(num);
                    num = (num * 2) + 1;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 1;

            for (int row = 0; cnt <= n; row++)
            {
                for (int col = 0; col <= row  ; col++)
                {
                    Console.Write("{0} " , cnt);
                    cnt++;
                }
                Console.WriteLine();
            }
        }
    }
                
}

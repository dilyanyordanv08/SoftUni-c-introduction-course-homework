﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                if (row == 0 || row == n - 1 )
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.WriteLine("| ");
                }
                
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" -");
                }
                if (row == 0 || row == n - 1)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("| ");
                }
            }
           
        }
    }
}

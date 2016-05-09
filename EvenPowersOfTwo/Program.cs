using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = 1;


            for (int cnt = 0; cnt < n + 1; cnt += 2)
            {
                Console.WriteLine(multiplier);
                multiplier = multiplier * 2 * 2;

            }
        }
    }
}

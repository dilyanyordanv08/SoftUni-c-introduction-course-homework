using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = n;
            if (n == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    result = result * i;
                    
                }
                Console.WriteLine(result);
            }
        }
    }
}

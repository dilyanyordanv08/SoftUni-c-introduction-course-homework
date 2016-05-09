using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var symbol = char.Parse(Console.ReadLine());
            var width = n;
            var tempValue = 1;
            

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', width / 2 - i), new string(symbol, tempValue));
                tempValue += 2;
            }
            Console.WriteLine(new string(symbol, n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', i + 1 ), new string(symbol, width - (2 * (i + 1))));
                
            }
            
        }
    }
}

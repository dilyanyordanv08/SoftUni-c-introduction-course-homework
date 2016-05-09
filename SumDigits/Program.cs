using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumator = 0;

            
                do 
                {
                    sumator += num % 10;
                    num /= 10;                 
                } while (num > 0) ;

            Console.WriteLine("Sum of digits is: {0}", sumator);

        }
    }
}

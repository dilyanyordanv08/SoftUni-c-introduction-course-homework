using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sumEven = 0.00;
            var maxEven = 0.00;
            var minEven = 0.00;
            var minOdd = 0.00;
            var maxOdd = 0.00;
            var sumOdd = 0.00;

          var counter1 = 100000000;
          var  counter2 = -10000000;

            for (int i = 1; (i > counter2) && (i < counter1); i++)
            {
                var nums = double.Parse(Console.ReadLine());
                if (nums % 2 == 0)
                {
                    sumEven = sumEven + nums;
                    Console.WriteLine(sumEven);
                }
            }
              
           

            

    }
    }
}

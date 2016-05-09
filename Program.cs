using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());

           var price = 0.00;

            if (type == "Premiere")
            {
                price = 12;
            }
            else if (type == "Normal")
            {
                price = 7.50;
            }
            else if (type == "Discount")
            {
                price = 5;
            }
            Console.WriteLine("{0}", + ( price * row * column));

        }
    }
}

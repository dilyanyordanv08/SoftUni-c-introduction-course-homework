using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());

            decimal pizzaPrice = decimal.Parse(Console.ReadLine()) / rate;
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine()) / rate;
            decimal sandwichPrice = decimal.Parse(Console.ReadLine()) / rate;

            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal spentForPizza = pizzaPrice * pizzaQuantity;
            decimal spentForLasagna = lasagnaPrice * lasagnaQuantity;
            decimal spentForSandwich = sandwichPrice * sandwichQuantity;

            decimal totalNeeded = spentForLasagna + spentForPizza + spentForSandwich;

            if ( money - totalNeeded >= 0)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", money - totalNeeded);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", Math.Abs(money - totalNeeded));
            }   
        }
    }
}

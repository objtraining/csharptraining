using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set base of the power: ");
            int baseNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Set exponent of the power: ");
            int exponentNumber = Int32.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= exponentNumber; i++)
            {
                result = result * baseNumber;
            }

            Console.WriteLine("Pow is equal to: " + result);

            Console.ReadKey();
        }
    }
}
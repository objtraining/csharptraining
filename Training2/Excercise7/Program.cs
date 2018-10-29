using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type an integer number: ");
            int number = Int32.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of the number {0} is equal: {1} - loop", number, factorial);

           
            int Factorial(int j)
            {
                if (j == 1) {
                    return 1;
                }
                return j * Factorial(j - 1);
            }
            int factorialRecurence = Factorial(number);
            Console.WriteLine("Factorial of the number {0} is equal: {1} - loop", number, factorialRecurence);

            Console.ReadKey();
        }
    }
}

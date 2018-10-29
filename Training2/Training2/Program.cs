using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which Fibonacci number do you want to obtain: ");
            int number = Int32.Parse(Console.ReadLine());
            List<int> fibonacciSequence = new List<int>();
            fibonacciSequence.Add(0);
            fibonacciSequence.Add(1);
            int fibonacciNumber;

            switch (number)
            {
                case 0:
                    fibonacciNumber = fibonacciSequence[0];
                    break;
                case 1:
                    fibonacciNumber = fibonacciSequence[1];
                    break;
                default:
                    for (int i = 0; i < number - 1; i++)
                    {
                        fibonacciSequence.Add(fibonacciSequence[i] + fibonacciSequence[i + 1]);
                    }
                    fibonacciNumber = fibonacciSequence[fibonacciSequence.Count-1];
                    break;
            }

            Console.WriteLine("The {0} Fibanacci number is: {1}",number,fibonacciNumber);
            Console.ReadKey();
        }
    }
}

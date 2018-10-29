using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter the second integer number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int result;
            List<int> divaders = new List<int>();
            divaders.Add(firstNumber);
            divaders.Add(secondNumber);
            result = 1;
            int j = 0;
            while (result != 0)
            {
                result = divaders[j] % divaders[j + 1];
                divaders.Add(result);
                j++;
            }

            Console.WriteLine("The biggest divider of {0} ane {1} is {2}.", firstNumber, secondNumber, divaders[divaders.Count - 2]);


            Console.ReadKey();
        }
    }
}

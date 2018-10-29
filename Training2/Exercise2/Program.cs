using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer number: ");
            int number = Int32.Parse(Console.ReadLine());
            List<int> divaders = new List<int>();

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    divaders.Add(i);
                }
            }
            if (divaders.Count == 0)
            {
                Console.WriteLine("Is a prime");
            }
            else
            {
                Console.Write("Divides by ");
                int j = divaders.Count - 1;
                foreach (int i in divaders)
                {
                    if (j == 0)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                    j--;
                }
                Console.WriteLine();
                Console.WriteLine("Is not a prime");
            }
            Console.ReadKey();
        }
    }
}
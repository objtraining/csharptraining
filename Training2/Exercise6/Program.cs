using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type some big integer number: ");
            var bigNumberString = Console.ReadLine();

            int[] singleNumbers = new int[bigNumberString.Length];
            int sum = 0;
            for (int i = 0; i < singleNumbers.Length; i++)
            {
                singleNumbers[i] = Int32.Parse(bigNumberString[i].ToString());
                sum += singleNumbers[i];
            }                   
            Console.WriteLine("Sum of the integers is: {0} - loop",sum);

            int Sum(int j) {

                if (j == 0) {
                    return singleNumbers[j];
                }

                return singleNumbers[j] + Sum(j - 1);
            }

            Console.WriteLine("Sum of the integers is: {0} - recurence", Sum(singleNumbers.Length-1));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            string[] parts = number.Split(',');

            int lenghtOfFractionPart = 0;
            long fractionPartOfNumber = 0;
            if (parts.Length == 2)
            {
                lenghtOfFractionPart = parts[1].Length;
                fractionPartOfNumber = Int64.Parse(parts[1]);
            }

            int intPartOfNumber = Int32.Parse(parts[0]);
            //Console.WriteLine("Whole number: {0}, First part: {1}, Second part: {2} and lenght: {3}", number, intPartOfNumber, fractionPartOfNumber, lenghtOfFractionPart);
            string num = "1";
            string zeroes = "";
            zeroes = zeroes.PadRight(lenghtOfFractionPart, '0');
            num = num + zeroes;
            long denominator = long.Parse(num);

            long divider = Program.BiggestDivider(fractionPartOfNumber, denominator);
            long numerator = fractionPartOfNumber / divider;
            denominator = denominator / divider;

            if (numerator == 0)
            {
                Console.WriteLine("Number {0} is not a fraction", intPartOfNumber);
            }
            else
            {
                Console.WriteLine("Number as fraction: {0} {1}/{2}", intPartOfNumber, numerator, denominator);
            }
            Console.ReadKey();
        }


        public static long BiggestDivider(long firstNumber, long secondNumber)
        {
            List<long> divaders = new List<long>();
            divaders.Add(firstNumber);
            divaders.Add(secondNumber);
            long result = 1;
            int j = 0;
            while (result != 0)
            {
                result = divaders[j] % divaders[j + 1];
                divaders.Add(result);
                j++;
            }
            return divaders[divaders.Count - 2];
        }
    }
}
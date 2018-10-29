using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = { 13, 2, 3, 11, 5, -8, -10 };


            Console.Write("Numbers in table: ");
            foreach (int i in table)
            {
                Console.Write(i + " ");
            }

            Console.Write("\nMinimum value is: ");
            int min = table[0];
            for (int i = 0; i < table.Length - 1; i++)
            {
                if (min > table[i + 1])
                {
                    min = table[i + 1];
                }
            }
            Console.Write(min);

            Console.Write("\nMaximum value is: ");
            int max = table[0];
            for (int i = 0; i < table.Length - 1; i++)
            {
                if (max < table[i + 1])
                {
                    max = table[i + 1];
                }
            }
            Console.Write(max);

            Console.Write("\nSum of the numbers in the table is: ");
            int sum = 0;
            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }
            Console.Write(sum);

            Console.Write("\nAverage of the numbers in the table is: ");
            double avg = (double)sum / table.Length;
            Console.Write(avg.ToString("F"));

            Console.Write("\nSorted numbers: ");
            int[] sortedTable = (int[])table.Clone();


            for (int i = 0; i < table.Length - 2; i++)
            {
                for (int j = 0; j < table.Length - 1; j++)
                {
                    if (sortedTable[j] > sortedTable[j + 1])
                    {
                        int b = sortedTable[j];
                        sortedTable[j] = sortedTable[j + 1];
                        sortedTable[j + 1] = b;
                    }
                }
            }

            Console.Write("Numbers in sorted table: ");
            foreach (int i in sortedTable)
            {
                Console.Write(i + " ");
            }


            Console.Write("\nReversed numbers: ");
            int[] reversedTable = new int[7];
            for (int i = 0; i < table.Length; i++)
            {
                reversedTable[i] = table[table.Length - 1 - i];
            }
            Console.Write("Numbers in reversed table: ");
            foreach (int i in reversedTable)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
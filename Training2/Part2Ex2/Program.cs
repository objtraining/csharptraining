using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> listWithInts = new List<int>();
            listWithInts.Add(4);
            listWithInts.Add(7);
            listWithInts.Add(-9);
            listWithInts.Add(0);
            listWithInts.Add(2);

            Console.Write("Numbers in the list: ");
            WriteListElements(listWithInts);

            Console.WriteLine("\nMinimum number is: {0}", FindExtremum(listWithInts, true));

            Console.WriteLine("Maximum number is: {0}", FindExtremum(listWithInts, false));

            int calculatedSum = CalculateSum(listWithInts);
            Console.WriteLine("Sum of the numbers in the list: {0}", calculatedSum);

            double avg = (double)calculatedSum / listWithInts.Count();
            Console.WriteLine("Average of the numbers in the list: {0}", avg.ToString("F"));

            Console.Write("Numbers in the sorted list: ");
            WriteListElements(SortList(listWithInts));

            Console.Write("\nNumbers in the reversed list: ");
            WriteListElements(ReverseList(listWithInts));

            Console.ReadKey();



        }

        public static void WriteListElements(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        public static int FindExtremum(List<int> list, bool isMin)
        {
            int min = list[0];
            int max = list[0];
            for (int i = 0; i < list.Count(); i++)
            {
                if (min > list[i])
                {
                    min = list[i];
                }
                if (max < list[i])
                {
                    max = list[i];
                }
            }
            if (isMin == true)
            {
                return min;
            }
            else
            {
                return max;
            }
        }

        public static int CalculateSum(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            return sum;
        }

        public static List<int> SortList(List<int> list)
        {
            List<int> sortedList = new List<int>(list);
            int a;
            for (int j = 0; j < sortedList.Count() - 2; j++)
            {
                for (int k = 0; k < sortedList.Count() - 1; k++)
                {
                    if (sortedList[k] > sortedList[k + 1])
                    {
                        a = sortedList[k];
                        sortedList[k] = sortedList[k + 1];
                        sortedList[k + 1] = a;
                    }
                }
            }
            return sortedList;
        }

        public static List<int> ReverseList(List<int> list)
        {
            List<int> reversedList = new List<int>();
            for (int i = 0; i < list.Count(); i++)
            {
                reversedList.Add(list[list.Count() - 1 - i]);
            }
            return reversedList;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string text = Console.ReadLine();

            Console.Write("Enter the letter: ");
            string letter = Console.ReadLine();

            int number = Program.CountLetterInSentence(text, letter);

            if (number == 0)
            {
                Console.WriteLine("Letter {0} was never used in provided sentence", letter);
            }
            else
            {
                Console.WriteLine("Letter {0} is repeated in provided sentence {1} times.", letter, number);
            }

            Console.WriteLine("\nReveresed sentence: {0}", Program.ReverseSentense(text));

            Console.ReadKey();
        }

        public static int CountLetterInSentence(string str, string letter)
        {

            int counter = 0;
            char[] chartable = str.ToLower().ToCharArray();

            foreach (char ch in chartable)
            {
                if (ch.ToString().Equals(letter.ToLower()))
                {
                    counter++;
                }
            }
            return counter;
        }

        public static string ReverseSentense(string str)
        {
            char[] charSentence = str.ToCharArray();
            char[] reversedSentence = new char[charSentence.Length];


            for (int i = 0; i < charSentence.Length; i++)
            {
                reversedSentence[i] = charSentence[charSentence.Length - 1 - i];
            }

            string reversedText = new string(reversedSentence);
            return reversedText;
        }
    }
}
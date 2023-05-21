using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class Program
    {
        // Recursive function to guess the number
        public static int GuessNumberRecursive(int low, int high)
        {
            if (low == high)
            {
                return low;
            }

            int mid = (low + high) / 2;

            Console.Write("Is the number between {0} and {1}? (y/n): ", low, mid);
            char response = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (response == 'y' || response == 'Y')
            {
                return GuessNumberRecursive(low, mid);
            }
            else
            {
                return GuessNumberRecursive(mid + 1, high);
            }
        }

        public static void Main(string[] args)
        {

            Console.Write("Enter the value of N (where N = 2^n): ");
            int n = int.Parse(Console.ReadLine());

            int low = 0;
            int high = (int)Math.Pow(2, n) - 1;

            Console.WriteLine("Think of a number between 0 and {0} (inclusive).", high);

            int guessedNumber = GuessNumberRecursive(low, high);

            Console.WriteLine("The number you were thinking of is: " + guessedNumber);
            Console.ReadKey();
        }
    }
}

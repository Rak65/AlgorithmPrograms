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
        // Function to check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to square root of the number
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers in the range of 0 to 1000:");

            for (int i = 0; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console .ReadKey();

        }
    }
}

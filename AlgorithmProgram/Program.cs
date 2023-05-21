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
        // Bubble Sort algorithm to sort an array
        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // Swap arr[j] and arr[j + 1]
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                // If no elements were swapped in the inner loop, the array is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void Main(string[] args)
        {
               // Prompt the user to enter the number of integers
                Console.Write("Enter the number of integers: ");
                int count = int.Parse(Console.ReadLine());

                // Create an array to store the integers
                int[] numbers = new int[count];

                // Prompt the user to enter the integers
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter integer #{0}: ", i + 1);
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                // Sort the array using Bubble Sort
                Sort(numbers);

                // Print the sorted array
                Console.WriteLine("Sorted List:");
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }
            Console.ReadKey();
            
        }
    }
}

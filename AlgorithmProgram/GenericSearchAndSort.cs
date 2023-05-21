using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    public class GenericSearchAndSort<T> where T : IComparable<T>
    {
        // Binary Search Algorithm
        public static bool BinarySearch(T[] array, T searchItem)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int comparison = searchItem.CompareTo(array[mid]);

                if (comparison == 0)
                {
                    return true;
                }
                else if (comparison < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return false;
        }

        // Bubble Sort Algorithm
        public static void BubbleSort(T[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

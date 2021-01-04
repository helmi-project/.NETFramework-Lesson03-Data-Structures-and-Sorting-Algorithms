using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 50, 10, 30, 20, 40 };
            int left = 0; //index pertama
            int right = 4; //index terakhir

            int[] sortedNumbers = QuickSortAlgorithm.QuickSort(numbers, left, right);
            foreach (int sortedNumber in sortedNumbers)
                Console.Write("{0}, ", sortedNumber);
        }
    }
}

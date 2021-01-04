using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 30, 10, 40 };

            int[] sortedNumbers = BubbleSortAlgorithm.BubbleSort(numbers);
            foreach (int sortedNumber in sortedNumbers)
                Console.Write("{0}, ", sortedNumber);
        }
    }
}

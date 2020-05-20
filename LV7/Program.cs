using System;

namespace LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { -65,-10, -8, -6, -4, 0, 2, 5, 8, 10, 16 };
            NumberSequence sequence = new NumberSequence(array);
            //BubbleSort bubble = new BubbleSort();
            //sequence.SetSortStrategy(bubble);

            //Console.WriteLine("Unsorted array:\n" + sequence.ToString());

            //sequence.Sort();
            //Console.WriteLine("Sorted array:\n" + sequence.ToString()); // ZADATAK 1
            LinearSearch linearSearch = new LinearSearch();
            sequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(sequence.Search(66));          // ZADATAK 2
        }
    }
}

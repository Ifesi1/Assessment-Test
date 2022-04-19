using System;

namespace Question1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 121, 23, 34, 41, 72 };
        }
        public static int LargestNumber(int array, int largest, int i)
        {
            if (i<0)
            {
                return largest;
            }
            if (largest<=array[i])
            {
                largest = array[i];
            }
            return LargestNumber(array, largest, i - 1);
        }
    }
}

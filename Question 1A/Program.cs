using System;

namespace Question_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 17, 28, 21, 12, 43 };

            int max = array[0];
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
                if (array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The sum of the largest and smallest number is: "+ (max+min));
            
        }
    }
}

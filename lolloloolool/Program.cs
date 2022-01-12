using System;

namespace lolloloolool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("От колко числа да е масива: ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            double temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;

                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (double p in array)
                Console.Write(p + " ");
        }
    }
}

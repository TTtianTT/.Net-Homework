using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8, 7, 9, 56, 85, 412, 4, 6, 945, 1, 5, 4125 };
            func(nums, out int min, out int max, out int sum, out float average);
            Console.WriteLine($"min={min},max={max},sum={sum},average={average}");
        }
        private static void func(int[] arr, out int min, out int max, out int sum, out float avg)
        {
            min = max = sum = arr[0];

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                sum += arr[i];
            }
            avg = sum / arr.Length;
        }
    }
}

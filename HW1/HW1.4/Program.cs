using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HW1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 5, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine($"result:{IsToeplitzMatrix(matrix)}");
        }
        private static bool IsToeplitzMatrix(int[,] matrix)
        {
            bool flag = true;
            for (int i = 1; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                    {
                        flag = false;
                    }
            return flag;
        }
    }
}


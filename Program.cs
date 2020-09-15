using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数!");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> list = GetFactors(num);
            Console.Write("素因子有:");
            foreach (int i in list)
            {
                Console.Write("\t" + i);
            }
        }
        private static List<int> GetFactors(int num)
        {
            List<int> list = new List<int>();
            for (int i = 2; i * i < num; i++)
                if (num % i == 0)
                {
                    list.Add(i);
                    num = num / i;
                }

            if (num != 1) { list.Add(num); }

            return list;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes = GetPrime();
            foreach (int num in primes)
            {
                Console.WriteLine(num);
            }
        }
        private static List<int> GetPrime()
        {
            List<int> primes = new List<int>();
            for (int i = 1; i <= 100; i++)//初始化List
                primes.Add(i);


            for (int i = 1; i < 101; i++)
            {
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0 && i / j != 1)
                    {
                        primes.Remove(i);//是某个数倍数的去掉
                    }
                }
            }
            return primes;
        }

    }
}


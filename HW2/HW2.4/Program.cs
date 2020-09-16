using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace HW2._4
{
    public delegate void Hanlder(int second);
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Alarm += alarm;
            clock.Tick += tick;
            clock.StartRun();
        }
        static void tick(int second)
        {
            Console.WriteLine($"TICK{second}");
        }
        static void alarm(int second)
        {
            Console.WriteLine($"ALARM{second}");
        }
    }
    class Clock
    {
        public bool IsWorking;
        public event Hanlder Tick;
        public event Hanlder Alarm;
        public Clock()
        {
            IsWorking = false;  
        }
        public void StartRun()
        {
            int startTime = 0;
            IsWorking = true;
            Tick(startTime);
            while(IsWorking)
            {
                Thread.Sleep(1000);
                startTime++;
                Tick(startTime);
                if(startTime == 10)
                {
                    Alarm(startTime);
                }
            }
        }

    }
}

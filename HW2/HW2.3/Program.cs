using System;

namespace HW2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 8, 9, 1, 2, 6 };

            Array.ForEach(array, m => Console.WriteLine(m));
            int sum = 0;
            Array.ForEach(array, m => sum += m);
            Console.WriteLine($"sum={sum}");
            int min = array[0];
            int max = array[0];
            Action<int> action = delegate (int item)
            {
                min = (item < min ? item : min);
            };
            Action<int> action2 = delegate (int item)
            {
                max = (item > max ? item : max);
            };
            Array.ForEach(array, action);
            Array.ForEach(array, action2);
            Console.WriteLine($"min={min}");
            Console.WriteLine($"max={max}");
        }
    }
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
    }
}

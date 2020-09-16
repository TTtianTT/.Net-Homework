using System;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);
            genericList.Add(5);
            genericList.Add(8);
            genericList.Add(9);
            genericList.Add(3);
            int sum = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            genericList.ForEach(item => Console.WriteLine(item));
            genericList.ForEach(item => sum += item);
            genericList.ForEach(item => { if (item > max) max = item; });
            genericList.ForEach(item => { if (item < min) min = item; });
            Console.WriteLine($"sum={sum},min={min},max={max}");

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
        public void ForEach(Action<T> action)
        {
            Node<T> n = head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }
}

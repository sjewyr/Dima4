using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima
{
    internal class Program
    {
        class Queue
        {
            public int Capacity = 10;
            int[] _item = new int[10];
            public int Count = 0;
            public Queue() { }
            public bool IsEmpty()
            {
                return (Count == 0);
            }
            public void Dequeue(int n)
            {
                if (Count == Capacity)
                {
                    Array.Resize(ref _item, Capacity * 2);
                    Capacity *= 2;
                }
                _item[Count] = n;
                Count++;
            }
            public int Enqueue()
            {
                int res = _item[0];
                Array.Copy(_item, 1, _item, 0, Capacity - 1);
                Count--;
                return res;
            }
            public void Print()
            {
                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine(_item[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            for (int n = 0; n < 100; n++) q.Dequeue(n);
            q.Print();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class DynamicStack<T>
    {
        private int MaxSize = 79;
        LinkedList<T> Buffer = new LinkedList<T>();

        public delegate void Adding(int a, int b);
        public delegate void Removing(int a, int b);
        public delegate void FullFill();
        public delegate void Abbys();

        public event Adding EvendHendlerAddelem;
        public event Removing EvendHendlerRemoveItem;
        public event FullFill EventHandlerBufferIsFull;
        public event Abbys EventHandlerBufferIsEmpty;

        public void Push(T toPushValue)
        {

            if (Buffer.Size < MaxSize)
            {
                Buffer.Add(toPushValue);
                EvendHendlerAddelem(MaxSize , Buffer.Size);
            }
            else
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Pop()
        {
            T temp;
            temp = Buffer.Get(Buffer.Size);
            Buffer.Remove(Buffer.Size);
            return temp;
        }

        public T Peek()
        {
            return Buffer.Get(Buffer.Size);
        }

        public void Print()
        {
            Buffer.Print();
        }
    }
}

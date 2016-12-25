using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class DynamicStack<T>
    {
        private int maxSize;
        LinkedList<T> Buffer = new LinkedList<T>();

        public int MaxSize
        {
         get { return maxSize; }
         set { maxSize = value; }
        }
       
        public delegate void Adding(int a, int b);
        public delegate void Removing(int a, int b);
        public delegate void FullFill();
        public delegate void Abbys();

        public event Adding EvendHendlerAddelem;
        public event Removing EvendHendlerRemoveItem;
        public event FullFill EventHandlerBufferIsFull;
        public event Abbys EventHandlerBufferIsEmpty;

        public class BufferIsFullException : SystemException
        {
            public void ErrorMessage(Exception ex)
            {
                Console.WriteLine("Buffer is full, nothing to do with this, Critical error:  {0}", ex);
                return;
            }
        }
        public class BufferIsEmptyException : SystemException
        {
            public void ErrorMessage(Exception ex)
            {
                Console.WriteLine("Buffer is empty, nothing to do with this, Critical error:  {0}", ex);
                return;
            }
        }

        public void Push(T toPushValue)
        {
            try
            {
                if (MaxSize > Buffer.Size)
                {
                    Buffer.Add(toPushValue);
                    if (EvendHendlerAddelem != null && Buffer.Size != MaxSize)
                    {
                        EvendHendlerAddelem(MaxSize, Buffer.Size);
                    }
                    if (Buffer.Size == MaxSize)
                    {
                        if (EventHandlerBufferIsFull != null)
                        {
                            EventHandlerBufferIsFull();
                        }
                    }
                }
                else
                {
                    BufferIsFullException ex = new BufferIsFullException();
                    throw ex;
                }
            }
            catch (BufferIsFullException)
            {
                BufferIsFullException m = new BufferIsFullException();
                m.ErrorMessage(m);
            }
            
        }

        public T Pop()
      {
            try
            {
                if (Buffer.Size > 0)
                {
                    T temp = Buffer.Get(Buffer.Size);
                    Buffer.Remove(Buffer.Size);
                    if (EvendHendlerRemoveItem != null && Buffer.Size != 0)
                    {
                        EvendHendlerRemoveItem(MaxSize, Buffer.Size);
                    }
                    else if (Buffer.Size == 0)
                    {
                        if (EventHandlerBufferIsEmpty != null)
                        {
                            EventHandlerBufferIsEmpty();
                        }

                    }
                    return temp;
                }
                else
                {
                    BufferIsEmptyException ex = new BufferIsEmptyException();
                    throw ex;
                }
            }
            catch (BufferIsEmptyException)
            {
                BufferIsEmptyException m = new BufferIsEmptyException();
                m.ErrorMessage(m);
                return default(T);
            }
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

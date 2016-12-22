using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class LinkedList<T>
    {
       class Node<K>
        {

            internal Node(K value)
            {
                Data = value;
            }
            public K Data { get; set; }
            public Node<K> NextNode { get; set; }
        }

        private Node<T> _head;
        private Node<T> _tail;
        private int size = 0;


        public void Add(T item)
        {
            Node<T> addNode = new Node<T>(item);

            if (_head == null)
            {
                _head = addNode;
                _tail = addNode;
            }
            else
            {
                _tail.NextNode = addNode;
                _tail = addNode;
            }
            size++;
        }

        public int Size
        {
            get { return size; }
        }

        public void Remove(int index)
        {
            int counter = 1;
            if (Checking(index))
            {
                Node<T> Temp = _head;
                Node<T> Previous = null;
                if (size == 1)
                {
                    _head = null;
                    size--;
                }
                else
                {
                    if (index == 1)
                    {
                        _head = _head.NextNode;
                        size--;
                        return;
                    }

                    while (counter < index)
                    {
                        Previous = Temp;
                        Temp = Temp.NextNode;
                        counter++;
                    }
                    if (size == index)
                    {
                        _tail = Previous;
                        Previous.NextNode = null;
                        size--;
                    }
                    else
                    {
                        Previous.NextNode = Temp.NextNode;
                        size--;
                    }
                }
            }

        }

        public T Get(int index)
        {
            int counter = 1;
            if (Checking(index))
            {
                Node<T> Temp = _head;
                if (index == 1)
                {
                    return _head.Data;
                }
                while (counter < index)
                {
                    Temp = Temp.NextNode;
                    counter++;
                }
                return Temp.Data;
            }
            return default(T);

        }

        public void Print()
        {
            Node<T> Temp = _head;
            int counter = 1;
            while (counter <= size)
            {
                Console.WriteLine(Temp.Data);
                Temp = Temp.NextNode;
                counter++;
            }

        }

        public void Insert(T item, int index)
        {
            int counter = 1;
            Node<T> InsNode = new Node<T>(item);
            if (Checking(index))
            {

                Node<T> Temp = _head;
                Node<T> Previous = null;
                if (index == 1)
                {
                    InsNode.NextNode = _head;
                    _head = InsNode;
                    return;
                }
                while (counter < index)
                {
                    Previous = Temp;
                    Temp = Temp.NextNode;
                    counter++;
                }
                InsNode.NextNode = Temp.NextNode;
                Previous.NextNode = InsNode;
                size++;
            }
            else if (_head == null && index == 1)
            {
                _head = InsNode;
                _tail = InsNode;
                size++;
            }
        }

        private bool Checking(int index)
        {
            if (_head == null || index > size)
            {
                Console.WriteLine("Buffer is empty, or index is out of range");
                return false;
            }
            return true;
        }
    }
}

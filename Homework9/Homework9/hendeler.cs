using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class EventHendlerForQueueAndStack
    {
        public void MessageAdd(int a, int b) 
        {
            a = a - b;
            Console.WriteLine("Element added to buffer there are {0} free places in buffer", a);
        }
        public void MessageRem(int a, int b)
        {
            a = a - b;
            Console.WriteLine("Element removed from buffer there are {0} free places in buffer", a);
        }

        public void MessageFull() 
        {
            Console.WriteLine("Buffer is full, please remove elements before adding new");
        }

        public void MessageEmpty()
        {
            Console.WriteLine("Buffer is Empty, please add elements before trying to get them");
        }
    }
        
}

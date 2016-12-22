using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    interface IMyQueue<T> : IPrintable
    {
        void Enqueue(T ElementToEnqueue);
        T Dequeue();

    }
}

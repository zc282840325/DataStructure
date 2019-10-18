using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
   public interface Queue<E>
    {
        int getSize();
        bool isEmpty();
        void enqueue(E e);
        E dequeue();
        E getFront();
    }
}

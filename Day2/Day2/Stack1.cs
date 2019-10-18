using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public interface Stack1<E>
    {
        int getSize();
        bool isEmpty();
        void push(E e);
        E pop();
        E peek();
    }
}

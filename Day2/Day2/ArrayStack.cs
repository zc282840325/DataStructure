using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class ArrayStack<E> : Stack<E>
    {
        Array<E> array;

        public ArrayStack(int capacity)
        {
            array = new Array<E>(capacity);
        }
        public ArrayStack()
        {
            array = new Array<E>();
        }
        public int getSize()
        {
            return array.getSize();
        }

        public bool isEmpty()
        {
            return array.isEmpty();
        }
        public int getCapacity()
        {
            return array.getCapacity();
        }

        public E peek()
        {
            return array.getLast();
        }

        public E pop()
        {
            return array.removeLast();
        }

        public void push(E e)
        {
            array.addLast(e);
        }
        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Stack:");
            res.Append("[");
            for (int i = 0; i < array.getSize(); i++)
            {
                res.Append(array.get(i));
                if (i!=array.getSize()-1)
                {
                    res.Append(", ");
                }
            }
            res.Append("] top");
            return res.ToString();
        }
    }
}

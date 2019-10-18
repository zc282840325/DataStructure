using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class ArrayQueue<E> : Queue<E>
    {
        private Array<E> array;
        public ArrayQueue(int capacity)
        {
            array = new Array<E>(capacity);
        }
        public ArrayQueue()
        {
            array = new Array<E>();
        }
        //取
        public E dequeue()
        {
            return array.removeFirst();
        }
        //添
        public void enqueue(E e)
        {
            array.addLast(e);
        }

        public E getFront()
        {
            return array.getFirst();
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

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("Queue:");
            res.Append("fornt[:");
            for (int i = 0; i < array.getSize(); i++)
            {
                res.Append(array.get(i));
                if (i!=array.getSize()-1)
                {
                    res.Append(",");
                }
            }
            res.Append("]tail");
            return res.ToString();
        }
    }
}

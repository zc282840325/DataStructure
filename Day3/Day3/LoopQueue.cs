using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class LoopQueue<E> : Queue<E>
    {
        private E[] data;
        private int front, tail;
        private int size;

        public LoopQueue(int capacity)
        {
            data = new E[capacity+1];
            front = 0;
            tail = 0;
            size = 0;
        }
        public LoopQueue()
        {
            data = new E[11];
        }
        public int getCapacity()
        {
            return data.Length - 1;
        }

        public E dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Connot dequeue from an empty queue.");
            }
            E ret = data[front];
            data[front] = default(E);
            front = (front + 1 )% data.Length;
            size--;
            if (size==getCapacity()/4&& getCapacity() / 2!=0)
            {
                resize(getCapacity() / 2);
            }
            return ret;
        }

        public void enqueue(E e)
        {
            //判断队列是否满
            if ((tail+1)%data.Length==front)
            {
                resize(getCapacity()*2);
            }
            data[tail] = e;
            tail = (tail + 1) % data.Length;
            size++;
        }

        private void resize(int v)
        {
            E[] newData = new E[v+1];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[(i+front)%data.Length];
            }
            data = newData;
            front = 0;
            tail = size;
        }

        public E getFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            return data[front];
          
        }

        public int getSize()
        {
            return size;
        }

        public bool isEmpty()
        {
            return front == tail;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(String.Format("Queue:size={0}，capacity={1}\r\n",size,getCapacity()));
            res.Append("fornt[:");
            for (int i = front;i!=tail; i=(i+1)%data.Length)
            {
                res.Append(data[i]);
                if ((i + 1) % data.Length!=tail)
                {
                    res.Append(",");
                }
            }
            res.Append("]tail");
            return res.ToString();
        }
    }
}

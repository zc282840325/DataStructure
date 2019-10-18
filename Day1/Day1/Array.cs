using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
   public class Array<E>
    {
        private E[] data;
        private int size;
        //构造函数，传入数组的容量capacity构造Array
        public Array(int capacity)
        {
            data = new E[capacity];
            size = 0;
        }
        //无参数的构造函数，默认数组的容量capacity=10
        public Array()
        {
            data = new E[10];
        }
        //获取数组中的元素个数
        public int getSize()
        {
            return size;
        }
        //获取数组的容量
        public int getCapacity()
        {
            return data.Length;
        }
        //返回数组是否为空
        public bool isEmpty()
        {
            return size == 0;
        }
        //向所有元素后添加一个新元素
        public void addLast(E e)
        {
            add(size, e);
        }
        //向数组的头部插入一个新元素e
        public void addFirst(E e)
        {
            add(0, e);
        }
        //在第index个位置插入一个新元素e
        public void add(int index, E e)
        {
           
            if (index < 0 || index > size)
                Console.WriteLine("Add failed.Require index>=0.");
            if (size == data.Length)
                resize(2*data.Length);
            for (int i = size - 1; i >= index; i--)
                data[i +1] = data[i];

            data[index] = e;
            size++;
        }

        private void resize(int newCapacity)
        {
            E[] newData = new E[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newData[i] = data[i];
            }
            data = newData;

        }

        //获取Index索引位置的元素
        public E get(int index)
        {
            if (index < 0 || index >= size)
                Console.WriteLine("Get failed.Index is illegal.");
            return data[index];
        }
        //修改index索引位置的元素为e
        public void set(int index, E e)
        {
            if (index < 0 || index >= size)
                Console.WriteLine("Get failed.Index is illegal.");
            data[index] = e;
        }
        //查找数组中是否有元素e
        public bool contains(E e)
        {
            for (int i = 0; i < size; i++)
            {
                if (data[i].ToString()==e.ToString())
                    return true;
            }
            return false;
        }
        //查找数组中元素e所在的索引，如果不存在元素e,则返回-1
        public int find(E e)
        {
            for (int i = 0; i < size; i++)
                if (data[i].ToString() == e.ToString())
                    return i;

            return -1;
        }
        public E remove(int index)
        {
            if (index < 0 || index > size)
                Console.WriteLine("delete failed.Require index>=0.");

            for (int i = index; i < size-1; i++)
                data[i] = data[i + 1];
            E ret = data[index];
            size--;
            data[size] = default(E);
            if (size==data.Length/4&&data.Length/2!=0)
            {
                resize(data.Length/2);
            }
            return ret;
        }
        //从数组中删除第一个元素，返回删除的元素
        public E removeFirst()
        {
            return remove(0);
        }
        //从数组中删除最后一个元素，则返回删除的元素
        public E removeLast()
        {
            return remove(size - 1);
        }
        //从数组中删除元素e
        public void removeElement(E e)
        {
            int index = find(e);
            if (index != -1)
                remove(index);
        }
        public string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array:size={0},capacity={1}\n", size, data.Length));
            res.Append('[');
            for (int i = 0; i < size; i++)
            {
                res.Append(data[i]);
                if (i != size - 1)
                    res.Append(",");
            }
            res.Append(']');
            return res.ToString();
        }
    }
}

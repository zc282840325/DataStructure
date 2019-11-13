using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
   public class CircleArrayQueue
    {
        //使用数组模拟队列
        private int maxSize;//表示数组最大容量
        private int front;//front就指向队列的第一个元素
        private int rear;//real指向队列的最后一个元素的后一位置
        private int[] arr;//该数组存放数据，模拟队列

        public CircleArrayQueue(int arrMaxSize)
        {
            maxSize = arrMaxSize;
            arr = new int[maxSize];
        }
        //判断队列是否满
        public bool isFull()
        {
            return (rear + 1) % maxSize == front;
        }
        //判断队列是否为空
        public bool isEmpty()
        {
            return rear == front;
        }
        //添加数据到队列
        public void addQueue(int n)
        {
            if (isFull())
            {
                Console.WriteLine("队列已经满了！");
            }
            else
            {
                arr[rear] = n;
                //将readl后移
                rear = (rear + 1) % maxSize;
            }
        }

        //获取数据出队列
        public int getQueue()
        {
            if (isEmpty())
            {
                throw new Exception("队列已经满了");
            }
            else
            {
                //这里需要分析出front是指向队列的第一个元素
                //1.先把front对应的值保存到一个临时变量
                //2.将front后移,考虑取莫
                //3.将临时保存的变量返回
                int temp = arr[front];
                front = (front + 1) % maxSize;
                return temp;
            }
        }
        //显示队列的所有数据
        public void showQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("当前队列是空的，没有数据！");
            }
            //思路，从front开始变量，变量多少个元素
            for (int i = front; i < front+ size(); i++)
            {
                Console.Write(arr[i%maxSize] + "\t");
            }
            Console.WriteLine("");
        }
        //求当前数组的有效个数
        public int size()
        {
            return (rear + maxSize - front) % maxSize;
        }
        //显示队列的头数据，
        public int headQueue()
        {
            if (isEmpty())
            {
                throw new Exception("队列是空的");
            }
            else
            {
                return arr[front];
            }
        }
        //显示队列的尾数据
        public int footQueue()
        {
            if (isEmpty())
            {
                throw new Exception("队列是空的");
            }
            else
            {
                return arr[size()-1];
            }
        }
    }
}

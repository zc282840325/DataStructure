using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
   public class AarrayQueue
    {
        //使用数组模拟队列
        private int maxSize;//表示数组最大容量
        private int front;//指向队列头
        private int rear;//队列尾
        private int[] arr;//该数组存放数据，模拟队列
        //创建队列的构造器
        public AarrayQueue(int arrMaxSize)
        {
            maxSize = arrMaxSize;
            arr = new int[maxSize];
            front = -1;//指向队列的头部的前一个位置[不包含]
            rear = -1;//指向队列的尾部[包含]
        }
        //判断队列是否满
        public bool isFull()
        {
            return rear == maxSize - 1;
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
                rear++;
                arr[rear] = n;
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
                front++;
                return arr[front];
            }
        }
        //显示队列的所有数据
        public void showQueue()
        {
            if (isEmpty())
            {
                Console.WriteLine("当前队列是空的，没有数据！");
            }
            for (int i = 0; i < maxSize; i++)
            {
                Console.Write(arr[i]+"\t");
            }
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
                return arr[front+1];
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
                return arr[rear];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个队列
            #region 测试数组模拟队列
            //AarrayQueue queue = new AarrayQueue(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    queue.addQueue(i);
            //}

            //Console.WriteLine("获取队列头部的数据：" + queue.headQueue());

            //Console.WriteLine("出队" + queue.getQueue());
            //Console.WriteLine("获取队列尾部的数据：" + queue.footQueue());
            //queue.showQueue();
            #endregion

            #region 测试数组模拟环形队列
            CircleArrayQueue circle = new CircleArrayQueue(5);
            for (int i = 0; i < 3; i++)
            {
                circle.addQueue(i);
            }
            Console.WriteLine("获取队列头部的数据：" + circle.headQueue());
            Console.WriteLine("出队" + circle.getQueue());
            circle.showQueue();
            Console.WriteLine("出队" + circle.getQueue());
            circle.showQueue();
            Console.WriteLine("出队" + circle.getQueue());
            circle.showQueue();
            circle.addQueue(7);
            circle.addQueue(8);
            circle.addQueue(9);
            circle.showQueue();
            #endregion
            Console.ReadKey();
        }
    }
}

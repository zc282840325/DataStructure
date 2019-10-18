using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayQueue<int> queue = new ArrayQueue<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    queue.enqueue(i);
            //    Console.WriteLine(queue.ToString());
            //    if (i%3==2)
            //    {
            //        queue.dequeue();
            //        Console.WriteLine(queue.ToString());
            //    }
            //}

            //---------------------------------------------------------
            //LoopQueue<int> queue = new LoopQueue<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    queue.enqueue(i);
            //    Console.WriteLine(queue.ToString());
            //    if (i % 3 == 2)
            //    {
            //        queue.dequeue();
            //        Console.WriteLine(queue.ToString());
            //    }
            //}

            //-----------------------------------------------------------
            int opCount = 100000;

            ArrayQueue<int> arrayQueue = new ArrayQueue<int>();
            double time1 = testQueue(arrayQueue,opCount);
            Console.WriteLine("ArrayQueue,time:"+time1+"s");

            LoopQueue<int> loopQueue = new LoopQueue<int>();
            double time2 = testQueue(loopQueue,opCount);
            Console.WriteLine("LoopQueue,time:" + time2 + "s");


        }
        private static double testQueue(Queue<int> q,int opCount)
        {
            long startTime = DateTime.Now.Ticks;
            Random random = new Random();
            for (int i = 0; i < opCount; i++)
            {
                q.enqueue(random.Next(int.MaxValue));
            }

            for (int i = 0; i < opCount; i++)
            {
                q.dequeue();
            }
            long endTime = DateTime.Now.Ticks;
            return (endTime - startTime) / 1000000000.0;
        }
    }
}

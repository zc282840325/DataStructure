using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 101,34,119,1};
            //insertSort(arr);
            int len = 1000;
            int[] arrs = new int[len];
            for (int i = 0; i < len; i++)
            {
                Random random = new Random();
                int a = (int)random.Next(0, len);
                arrs[i] = a;
                Thread.Sleep(1);
            }
            DateTime date1 = DateTime.Now;
            Console.WriteLine("插入排序前的时间是" + date1.ToString("HH:mm:ss fff"));
            insertSort(arrs);
            DateTime date2 = DateTime.Now;
            TimeSpan time = date2 - date1;
            Console.WriteLine("插入排序后的时间是" + date2.ToString("HH:mm:ss fff"));
            Console.WriteLine("插入排序：{0}个数据所用的时间:{1}", len, time.TotalMilliseconds);
        }
        //插入排序
        public static void insertSort(int[] arr)
        {
            for (int i = 1; i <arr.Length; i++)
            {
                //第一轮：=>{34,101,119,1}
                //定义待插入的数
                int inservalue = arr[i];
                int index = i - 1;//即arr[1]的前面这个数的下标

                //index>=0:保证在inservalue找插入位置，不越界
                //inservalue<arr[index]：待插入的数，还没有找到插入的位置
                //arr[index]后移
                while (index >= 0 && inservalue < arr[index])
                {
                    arr[index + 1] = arr[index];
                    index--;
                }
                //当退出while循环时，说明插入的位置找到index+1

                //判断
                if (index+1!=i)
                {
                    arr[index + 1] = inservalue;
                }
               
             //   Console.Write("第{0}轮插入:",i);
              //  print(arr);
            }
        }
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine("");
        }
    }
}

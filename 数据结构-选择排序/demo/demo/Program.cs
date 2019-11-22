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
           // int[] arr = {101,34,119,1 };
            int len = 1000;//修改数据量
            int[] arrs = new int[len];
            for (int i = 0; i < len; i++)
            {
                Random random = new Random();
                int a = (int)random.Next(0, len);
                arrs[i] = a;
                Thread.Sleep(1);
            }
            DateTime date1 = DateTime.Now;
            Console.WriteLine("选择排序前的时间是" + date1.ToString("HH:mm:ss fff"));
            selectSort(arrs);
            DateTime date2 = DateTime.Now;
            TimeSpan time = date2 - date1;
            Console.WriteLine("选择排序后的时间是" + date2.ToString("HH:mm:ss fff"));
            Console.WriteLine("选择排序：{0}个数据所用的时间:{1}", len, time.TotalMilliseconds);

        }
        //选择排序
        public static void selectSort(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                int min = arr[j];
                int index = j;
                for (int i = j+1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        index = i;
                        min = arr[i];
                    }
                }
               
                if (index != j)
                {
                    arr[index] = arr[j];
                    arr[j] = min;
                }
               // Console.WriteLine("第{0}轮排序：", j + 1);
               // print(arr);
                //if (j== arr.Length-2)
                //{
                //    break;
                //}
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

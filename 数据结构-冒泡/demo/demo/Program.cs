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
            int[] arr = {3,9,-1,10,20 };


            // bubbleSort(arr);
            // Console.WriteLine("最后的结果:");
            // print(arr);
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
            Console.WriteLine("冒泡排序前的时间是"+ date1.ToString("HH:mm:ss fff"));
            bubbleSort(arrs);
            DateTime date2 = DateTime.Now;
            TimeSpan time = date2 - date1;
            Console.WriteLine("冒泡排序后的时间是" + date2.ToString("HH:mm:ss fff"));
            Console.WriteLine("冒泡排序：{0}个数据所用的时间:{1}", len, time.TotalMilliseconds);
        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("");
        }
        public static void bubbleSort(int[] arr)
        {
            bool flag = false;//标识变量，表示是否进行交换
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        flag = true;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
              //  Console.Write("第" + (i + 1) + "趟排序后的数组：");
              //  print(arr);

                if (flag)//在一趟排序中，依次交换都没有发生过
                {
                    flag = false;//重置flag，进行下次判断
                }
                else
                {
                    break;
                }
            }
        }
    }
}

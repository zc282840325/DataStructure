using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {8,9,1,7,2,3,5,4,6,0 };
            test2(arr);
            print(arr);
        }
        /// <summary>
        ///  希尔换位法
        /// </summary>
        /// <param name="arr"></param>
        public static void shellSort(int[] arr)
        {
            //希尔排序的第一论
            //因为第一轮排序，是将10个数据分成5组，
            int temp = 0;
            int len = arr.Length;
            int count = 0;
            //将数组除2取分组的个数
            for (int num = len / 2; num >0; num/= 2)
            {
                //组队的值进行比较,满足条件就交换
                for (int i = num; i < arr.Length; i++)
                {
                    for (int j = i - num; j >= 0; j -= num)
                    {
                        //满足条件
                        if (arr[j] > arr[j + num])
                        {
                            //组内交换
                            temp = arr[j];
                            arr[j] = arr[j + num];
                            arr[j + num] = temp;
                        }
                    }
                }
                count++;
                Console.WriteLine("这是第{0}次排序", count);
                print(arr);
            }

        }
        /// <summary>
        /// 希尔移位法
        /// </summary>
        /// <param name="arr"></param>
        public static void shellSort2(int[] arr)
        {
            //希尔排序的第一论
            //因为第一轮排序，是将10个数据分成5组，
            int temp = 0;
            int len = arr.Length;
            int count = 0;
            //将数组除2取分组的个数
            for (int num = len / 2; num > 0; num /= 2)
            {
                //组队的值进行比较,满足条件就交换
                for (int i = num; i < arr.Length; i++)
                {
                    int j = i;
                    temp = arr[j];
                    if (arr[j]<arr[j-num])
                    {
                        //移位
                        while (j-num>=0&& temp<arr[j-num])
                        {
                            arr[j] = arr[j - num];
                            j -= num;
                        }
                        arr[j] = temp;
                    }
                }
                count++;
                Console.WriteLine("这是第{0}次排序", count);
                print(arr);
            }
        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("");
        }

        public static void test1(int[] arr)
        {
            int len = arr.Length;
            int temp = 0;
            for (int m = len/2; m >0; m/=2)
            {
            for (int i = m; i < len; i++)
            {
                for (int j =i- m; j >=0; j-= m)
                {
                    if (arr[j] > arr[j + m])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + m];
                        arr[j + m] = temp;
                    }
                }
            }
            }
        }

        public static void test2(int[] arr)
        {
            int len = arr.Length;//取数组长度
            int temp = 0;
            for (int m = len / 2; m > 0; m /= 2)
            {
                for (int i = m; i < len; i++)
                {
                    int j = i;
                    temp = arr[j];
                    if (arr[j]<arr[j-m])
                    {
                        while (j-m>=0&&temp<arr[j-m])
                        {
                            arr[j] = arr[j - m];
                            j -= m;
                        }
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}

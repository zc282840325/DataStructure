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
            int[] arr = { 34, 75, 489, 9, 123, 3 };
            radixSort(arr);
            print(arr);
            Console.ReadKey();
        }

        //基数排序方法
        public static void radixSort(int[] arr)
        {
            int[,] bucket = new int[10, arr.Length];
            int[] bucketElementCounts = new int[10];

            #region 去数组中的长度最长的数
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            max = max.ToString().Length;
            #endregion

            for (int m = 0, n = 1; m < max; m++, n *= 10)
            {
                #region 按照遍历的顺序，将数存入桶中，个位，十位...
                for (int i = 0; i < arr.Length; i++)
                {
                    //取出每个元素的个位
                    int digitOfElement = arr[i] / n % 10;
                    //放入对应的桶
                    bucket[digitOfElement, bucketElementCounts[digitOfElement]] = arr[i];
                    bucketElementCounts[digitOfElement]++;
                }
                #endregion

                #region 遍历桶，将数据重新写会数组汇中
                int index = 0;
                //遍历每一个桶
                for (int i = 0; i < bucketElementCounts.Length; i++)
                {
                    //如果桶有数据，我们才放到原数据中
                    if (bucketElementCounts[i] != 0)
                    {
                        //循环该桶
                        for (int k = 0; k < bucketElementCounts[i]; k++)
                        {
                            //取出元素放入arr
                            arr[index++] = bucket[i, k];
                        }
                    }
                    bucketElementCounts[i] = 0;
                }
                #endregion
            }
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="arr"></param>
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("");
        }
    }
}

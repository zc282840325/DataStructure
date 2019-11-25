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
            int[] arr = {8,4,5,7,1,3,6,2 };
            int[] temp = new int[arr.Length];
            mergeSort(arr,0,arr.Length-1,temp);
            print(arr);
            Console.ReadKey();
        }
        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("");
        }
        /// <summary>
        ///  归并排序
        /// </summary>
        /// <param name="arr">原始数组</param>
        /// <param name="left">左边有序序列的初始索引</param>
        /// <param name="mid">中间索引</param>
        /// <param name="right">右边索引</param>
        /// <param name="temp">临时数组</param>
        public static void merge(int[] arr,int left,int mid,int right,int[] temp)
        {
            int i = left;//左边初始化索引
            int j = mid + 1;//初始化j,右边初始化索引
            int index = 0;//指向temp当前索引

            //1.先把左右两边（有序）的数据按照规则填充到temp数组
            //直到左右两边的有序序列，有一边处理完毕为止
            while (i<=mid&&j<=right)
            {
                //如果左边的有序序列的当前元素，小于等于右边有序序列的当前元素
                //就把左边的插入临时数组，i需要后移，index后移
                if (arr[i]<=arr[j])
                {
                    temp[index] = arr[i];
                    index += 1;
                    i += 1;
                }
                else
                {
                    temp[index] = arr[j];
                    index += 1;
                    j += 1;
                }

            }

            //2.把有剩余数据的一边的数据依次全部填充到temp
            while (i<=mid)
            {
                temp[index] = arr[i];
                i+=1;
                index+=1;
            }
            while (j <= right)
            {
                temp[index] = arr[j];
                j+=1;
                index+=1;
            }

            //3.将temp数组的元素拷贝到arr
            //注意，并不是每次都拷贝所有
            index = 0;
            int templeft = left;
            while (templeft<=right)
            {
                arr[templeft] = temp[index];
                index += 1;
                templeft += 1;
            }
        }
        public static void mergeSort(int[] arr, int left, int right, int[] temp)
        {
            if (left<right)
            {
                int mid = (left + right) / 2;
                //向左递归
                mergeSort(arr,left,mid,temp);
                //向右递归
                mergeSort(arr, mid+1, right, temp);
                //到合并
                merge(arr,left,mid,right,temp);
            }
        }
    }
}

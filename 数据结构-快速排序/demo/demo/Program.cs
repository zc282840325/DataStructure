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
            int[] arr = {-9,78,0, 23 ,- 567,70,-1,900,4568 };
            // quickSort(arr,0,arr.Length-1);
            print(arr);
            Console.ReadKey();
        }
        public static void quickSort(int[] arr,int left,int right)
        {
            int l = left;//左下标
            int r = right;//右下标
            int temp = 0;
            //prvot 中轴值
            int prvot = arr[(l + r) / 2];
            //while循环的目的是让比prvot值小的左，比它大的放右边
            while (l < r)
            {
                //在prvot左边一直找，找到大于等于provt值，才推出
                while (arr[l] < prvot)
                {
                    l += 1;
                }
                //在prvot右边一直找，找到大于等于provt值，才推出
                while (arr[r] > prvot)
                {
                    r -= 1;
                }
                //[如果条件成立，prvot的左右两的值，已经按照左边全部是]
                if (l >= r)
                {
                    break;
                }
                //交换
                temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                //如果交换完，arr[l]==pivot值相等，前移
                if (arr[l] == prvot)
                {
                    r -= 1;
                }
                //如果交换完，arr[r]==pivot值相等，后移
                if (arr[r] == prvot)
                {
                    l += 1;
                }
            }
            //如果l==r,必须l++,r--，否则会出现栈溢出
            if (l == r)
            {
                l += 1;
                r -= 1;
            }
            //向左递归
            if (left < r)
            {
                quickSort(arr, left, r);
            }
            //向左递归
            if (right > l)
            {
                quickSort(arr, l, arr.Length);
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
    }
}

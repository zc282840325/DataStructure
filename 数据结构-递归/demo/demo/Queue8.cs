using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
   public class Queue8
    {
        //定义一个max表示有多少皇后
       public static int max = 8;
        //定义数组array,保存皇后的位置的结果
        public static int[] array = new int[max];
        public static int count = 0;

        //编写一个方法，放置第n个皇后
        public void check(int n)
        {
            //判断是否放完了8个皇后
            if (n==max)
            {
                print();
            }
            else
            {
                //依次放入皇后，并判断是否冲突
                for (int i = 0; i < max; i++)
                {
                    //先吧当前 这个皇后n,放到该行的第1列
                    array[n] = i;
                    if (judge(n))//不冲突
                    {
                        check(n+1);
                    }
                    else
                    {
                        //如果冲突，就继续执行array[n]=i;
                    }
                }
            }
        }


        //查看当我们放置第n个皇后，就去检查该皇后是否和前面已经摆放的皇后冲突
        public bool judge(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //判断是否在同一列、同一斜线
                //1.array[i]==array[n]判断是否在同一列
                //2.Math.Abs(n-i)==Math.Abs(array[n]-array[i])判断第n个皇后是否和第i个皇后在同一斜线
                if (array[i]==array[n]||Math.Abs(n-i)==Math.Abs(array[n]-array[i]))
                {
                    return false;
                }
            }
            return true;
        }
        //写个方法，将皇后的位置输出
        public void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine("");
            count++;
        }

         
    }
}

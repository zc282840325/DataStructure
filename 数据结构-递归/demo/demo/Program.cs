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
            #region 迷宫
            //创建一个二维数组，模拟迷宫
            int[,] map = new int[8,7];
            //使用1表示墙
            //先把上下全部设置为1
            for (int i = 0; i < 7; i++)
            {
                map[0, i] = 1;
                map[7, i] = 1;
            }
            //左右设置为1
            for (int i = 0; i < 8; i++)
            {
                map[i, 0] = 1;
                map[i, 6] = 1;
            }
            //设置挡板，1
            map[3, 1] = 1;
            map[3, 2] = 1;

            Console.WriteLine("原地图：");
            //输出地图
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(map[i,j]+"\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("找完迷宫的地图：");
            setway(map, 1, 1);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(map[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            #endregion

            //test(5);
            //Console.WriteLine(factorial(3));
        }



        //使用递归回溯来给小球栈路
        //说明
        //1.map表达式地图
        //2.i,j表示地图的哪个位置开始出发（1，1）
        //3.如果小球能到map[6][5]位置，则说明通路找到
        //4.约定：当map[i][j]为0表示该点没有走过当为1.表示墙；2.表示通路可以走；3.表示该带你已经走过，但是走不通
        //5.在走迷宫时，需要确定一个策略下-》右-》上-》左

        /// <summary>
        /// 使用递归回溯给小球找路
        /// </summary>
        /// <param name="map">地图</param>
        /// <param name="i">从i位置开始找</param>
        /// <param name="j">从j位置开始找</param>
        /// <returns>如果找到通路，就返回true,否则返回false</returns>
        public static bool setway(int[,] map,int i,int j)
        {
            if (map[6,5]==2)
            {
                return true;
            }
            else
            {
                if (map[i,j]==0)//如果当前这个点还没有走过
                {
                    //策略下-》右-》上-》左
                    map[i, j] = 2;//假定该点是可以走通。
                    //向下
                    if (setway(map,i+1,j))
                    {
                        return true;
                    }
                    //向右
                    else if (setway(map, i, j+1))
                    {
                        return true;
                    }
                    //向上
                    else if (setway(map, i - 1, j))
                    {
                        return true;
                    }
                    //向左
                    else if (setway(map, i, j-1))
                    {
                        return true;
                    }
                    else
                    {
                        //该点走不通
                        map[i, j] = 3;
                        return false;
                    }
                }
                else
                {
                    //如果mao[i][j]!=0,可能1：墙，2：已走过，3：死路
                    return false;

                }
            }
        }
        
        /// <summary>
        ///  打印
        /// </summary>
        /// <param name="n"></param>
        public static void test(int n)
        {
            if (n>2)
            {
                test(n-1);
            }
            else
            {
                Console.WriteLine(n);
            }
       
        }
        /// <summary>
        /// 阶乘
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int factorial(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return factorial(n - 1) * n;
            }
        }
    }
}

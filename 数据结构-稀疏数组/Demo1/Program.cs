using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filestr = Environment.CurrentDirectory + "//map.data";

            #region 初始化二维数据
            //先创建一个原始的二维数据11*11,
            //0:表示没有棋子，1表示黑子，2表示白子
            int[,] chese = new int[11, 11];
            chese[1, 2] = 1;
            chese[2, 4] = 2;
            chese[7, 8] = 2;
            chese[4, 9] = 1;
            #endregion

            #region 输出原始的二维数组
            //输出原始的二维数组
            Console.WriteLine("原始的二维数组：");
            for (int i = 0; i < Math.Sqrt(chese.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(chese.Length); j++)
                {
                    Console.Write("\t" + chese[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion

            #region 将二维数组转换为稀疏数组
            #region 第一步获取有效值的数据
            int sum = 0;
            for (int i = 0; i < Math.Sqrt(chese.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(chese.Length); j++)
                {
                    if (chese[i, j] != 0)
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine("稀疏数组的长度Sum={0}", sum);
            #endregion

            #region 第二步创建稀疏数组并赋值
            //创建稀疏数组
            int[,] res = new int[sum + 1, 3];
            //给稀疏数组赋值
            res[0, 0] = 11;
            res[0, 1] = 11;
            res[0, 2] = sum;
            //遍历二维数组，将非零的值存入稀疏数组
            int count = 0;
            for (int i = 0; i < Math.Sqrt(chese.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(chese.Length); j++)
                {
                    if (chese[i, j] != 0)
                    {
                        count++;
                        res[count, 0] = i;
                        res[count, 1] = j;
                        res[count, 2] = chese[i, j];
                    }
                }
            }
            #endregion

            #region 第三步打印稀疏数组的值
            //打印稀疏数组的值
            Console.WriteLine("稀疏数组:");
            for (int i = 0; i < res.Length / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + res[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion
            #endregion

            #region 将稀疏数组恢复成原始的数组

            #region 读取稀疏数组第一行，创建一个二维数组
            int row = res[0, 0];
            int clo = res[0, 1];
            int[,] newarr = new int[row,clo];
            for (int i = 1; i < res.Length/3; i++)
            {
                newarr[res[i, 0], res[i, 1]] = res[i, 2];
            }
            Console.WriteLine("输出转换后的二维数组：");
            for (int i = 0; i < Math.Sqrt(newarr.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(newarr.Length); j++)
                {
                    Console.Write("\t" + newarr[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion

            #endregion

            #region 将稀疏数组存入本地的磁盘中
            try
            {
             
                string strdata = "";
                for (int i = 0; i < res.Length / 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        strdata += res[i, j]+",";
                    }
                    strdata += "\r\n";
                }
                System.IO.File.WriteAllText(filestr, strdata);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.WriteLine("存入成功");

            #endregion

            #region 从磁盘读取稀疏数组
            string[] str_arr = File.ReadAllLines(filestr,Encoding.Default);
            int[,] new_xs =new int[str_arr.Length, 3];

            for (int i = 0; i < str_arr.Length; i++)
            {
                string[] head2 = str_arr[i].Split(',');
                new_xs[i, 0] = Convert.ToInt32(head2[0]);
                new_xs[i, 1] = Convert.ToInt32(head2[1]);
                new_xs[i, 2] = Convert.ToInt32(head2[2]);
            }
            Console.WriteLine("从磁盘读取的稀疏数组打印：");
            for (int i = 0; i < new_xs.Length / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t"+new_xs[i, j]);
                }
                Console.WriteLine("");
            }
            #endregion

            Console.ReadKey();                                                                                                                                                                                                                                                                                                                                                                                                                                                     
        }
    }
}

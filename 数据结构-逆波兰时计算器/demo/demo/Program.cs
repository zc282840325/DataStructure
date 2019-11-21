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
            PolandNotation poland = new PolandNotation();
            #region 后缀表达式实现计算器
            //string str = "(30+4)*5-6";
            //string str2 = "4*5-8+60+8/2";

            //string suffixExpression = "30 4 + 5 * 6 -";
            //suffixExpression = "1 2 3 + 4 * + 5 -";
            //PolandNotation poland = new PolandNotation();
            //List<string> list = poland.getListString(suffixExpression);
            //Console.WriteLine(poland.calculate(list));
            #endregion

            #region 中缀表达式转后缀表达式
            string str = "1+((3+2)*4)-5";
            List<string> list = poland.toInfixExpressionList(str);
            
            List<string> list2 = poland.parseSuffixExpressionList(list);
            Console.Write("后缀表达式：");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]);
            }
            Console.WriteLine("结果："+poland.calculate(list2));
            #endregion
            Console.ReadKey();

        }
    }
}

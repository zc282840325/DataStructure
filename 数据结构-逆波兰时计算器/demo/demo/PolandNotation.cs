using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace demo
{
   public class PolandNotation
    {
        public List<string> getListString(string suff)
        {
            string[] split = suff.Split(' ');
            List<string> list = new List<string>();
            foreach (var item in split)
            {
                list.Add(item);
            }
            return list;
        }
        public int calculate(List<string> list)
        {
            Stack<string> stack = new Stack<string>();
            foreach (var item in list)
            {
                Regex regExp = new Regex("^\\d+$");//匹配的是多位数
               
                if (regExp.IsMatch(item))
                {
                    //入栈
                    stack.Push(item);
                }
                else
                {
                    int num2 = Convert.ToInt32(stack.Pop());
                    int num1 = Convert.ToInt32(stack.Pop());
                    int res = 0;
                    if (item=="+")
                    {
                        res = num1 + num2;
                    }
                    else if (item == "-")
                    {
                         res = num1 - num2;
                    }
                    else if (item == "*")
                    {
                        res = num1 * num2;
                    }
                    else if (item == "/")
                    {
                        res = num1 / num2;
                    }
                    else
                    {
                        throw new Exception("运算符有问题！ ");
                    }
                    //把res入栈
                    stack.Push(""+res);
                }
            }

            return Convert.ToInt32(stack.Pop());
        }
    }

}

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
                Console.Write(item+",");
                list.Add(item);
            }
            Console.WriteLine("");
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

        public List<string> toInfixExpressionList(string s)
        {
            Console.Write("中缀表达式：");
            //定义一个List,存放中缀表达式对应的内容
            List<string> ls = new List<string>();
            int i = 0;//这时是一个指针，用于遍历中缀表达式
            string str;//对多位数的拼接
            char[] vs = s.ToCharArray();
            char c;//每遍历到一个字符，就放到c
            do
            {
                c = vs[i];
                //如果c是一个非数组，加入ls中
                if ((c<48)||c>57)
                {
                    ls.Add(""+c);
                    Console.Write(c+",");
                    i++;
                }
                else
                {
                    str = "";
                    while (i<s.Length&&c>=48&&c<=57)
                    {
                        str += c;//多位数
                        i++;
                        if (i<vs.Length)
                        {
                            c = vs[i];
                        }
                    }
                    ls.Add(str);
                    Console.Write(str+",");
                }
            } while (i<s.Length);

            return ls;
        }

        public List<string> parseSuffixExpressionList(List<string> ls)
        {
            //定义两个栈
            Stack<string> s1 = new Stack<string>();//符号栈
       //  Stack<string> s2 = new Stack<string>();//数值栈[只有入栈，没有出栈]
            List<string> s2 = new List<string>();
            string str = "";
            foreach (var item in ls)
            {
                Regex regExp = new Regex("^\\d+$");//匹配的是多位数
              
                if (regExp.IsMatch(item))
                {
                    //如果是数字
                    //入栈
                    s2.Add(item);
                }
                else if(item=="(")
                {
                    s1.Push(item);
                }
                else if (item==")")
                {
                    while (s1.Peek()!="(")
                    {
                        s2.Add(s1.Pop());
                    }
                    s1.Pop();//!!!将（弹出s1栈
                }
                else
                {
                    //当item小于等于栈顶运算符，将s1栈顶的运算符弹出并加入s2中，再次转到4.1与s1中心的栈顶运算符想比较
                    while (s1.Count != 0 && Operation.getValue(s1.Peek())>= Operation.getValue(item))
                    {
                        s2.Add(s1.Pop());
                    }
                    //还需要将item压入栈中
                    s1.Push(item);
                }
            }
            //将s1中剩余的运算符依次弹出并加入s2
            while (s1.Count()!=0)
            {
                s2.Add(s1.Pop());
            }
            return s2;
        }
        class Operation
        {
            private static int ADD = 1;
            private static int SUB = 1;
            private static int MUL = 2;
            private static int DIV = 2;

            public static int getValue(string operation)
            {
                int result = 0;
                switch (operation)
                {
                    case "+":
                        result = ADD;
                    break;
                    case "-":
                        result = SUB;
                        break;
                    case "*":
                        result = MUL;
                        break;
                    case "/":
                        result = DIV;
                        break;
                    default:
                        Console.WriteLine("不存在该运算符！");
                        break;
                }
                return result;
            }
        }

    }

}

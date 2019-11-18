using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数组模拟栈
            //ArrayStack stack = new ArrayStack(5);
            //for (int i = 0; i < 5; i++)
            //{
            //   // stack.push(i);
            //}
            //Console.WriteLine("数组模拟栈出栈：");
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Restart();
            //stack.showlist();
            //Console.WriteLine("使用时间：" + sw1.ElapsedMilliseconds);
            #endregion

            #region 链表模拟栈
            //LinkedStack linkedStack = new LinkedStack();
            //for (int i = 0; i < 5; i++)
            //{
            //    linkedStack.push(i);
            //   // stack.push(i);
            //}
            //Console.WriteLine("链表模拟栈出栈：");
            //Stopwatch sw = new Stopwatch();
            //sw.Restart();
            //linkedStack.showlist();
            //Console.WriteLine("使用时间："+ sw.ElapsedMilliseconds);

            #endregion

            #region 计算表达式(只能计算1-9的加、减、乘、除操作！)
           // string str = "7+2*6-20";
            string str = "7*2*2-5+1-5+3-4";
            char[] vs = str.ToCharArray();
            //声明两个栈，一个存放数字，一个存放符合
            ArrayStack2 numstack = new ArrayStack2(10);
            ArrayStack2 operstack = new ArrayStack2(10);
            int index = 0;
            int num1 = 0;
            int num2 = 0;
            int oper = 0;
            int res = 0;
            char ch = ' ';
            string keepNum = string.Empty;
            while (true)
            {
                //依次得str的每一个字符
                ch = vs[index];
                //判断ch是什么，然后做相应的处理
                if (operstack.isOper(ch))
                {
                    //判断当前的字符栈是否为空
                    if (!operstack.isEmpty())
                    {
                        if (operstack.priority(ch) <= operstack.priority(operstack.peek()))
                        {
                            num1 = numstack.pop();
                            num2 = numstack.pop();
                            oper = operstack.pop();
                            res = numstack.cal(num1, num2, oper);
                            //入栈
                            numstack.push(res);
                            //当前符号入符号栈
                            operstack.push(ch);
                        }
                        else
                        {
                            operstack.push(ch);
                        }
                    }
                    else
                    {
                      
                        operstack.push(ch);
                    }
                }
                else
                {
                    #region 处理多位数
                    //处理多位数
                    keepNum += ch;
                    //如果判断ch已经是vs的最后一个，就这几入栈
                    if (ch == vs[vs.Length - 1])
                    {
                        numstack.push(int.Parse(keepNum));
                    }
                    else
                    {
                        if (operstack.isOper(vs[index + 1]))
                        {
                            //如果后一位是运算符
                            numstack.push(int.Parse(keepNum));
                            //重要的！！！
                            keepNum = string.Empty;
                        }
                    }
                    #endregion

                    #region 单位数1-9
                    //数字入栈
                    // numstack.push(ch - 48);
                    #endregion

                }
                index++;
                if (index >= vs.Length)
                {
                    break;
                }
            }

            while (true)
            {
                //如果符号栈为空，则计算到最后的结果，数栈就是最终的结果
                if (operstack.isEmpty())
                {
                    break;
                }
                num1 = numstack.pop();
                num2 = numstack.pop();
                oper = operstack.pop();
                res = numstack.cal(num1, num2, oper);
                //入栈
                numstack.push(res);
            }

            Console.WriteLine("表达式：{0}的结果={1}", str, numstack.pop());
            #endregion

            Console.ReadKey();
        }
    }
}

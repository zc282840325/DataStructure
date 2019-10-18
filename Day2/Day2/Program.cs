using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> arrayStack = new ArrayStack<int>();
            for (int i = 0; i < 5; i++)
            {
                arrayStack.push(i);
                Console.WriteLine(arrayStack.ToString());
            }
            Console.WriteLine(arrayStack.ToString());
            arrayStack.pop();
            Console.WriteLine(arrayStack.ToString());

            Console.WriteLine(isValid("(]").ToString());
        }
        /// <summary>
        /// 有效的括号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            char[] vs = s.ToCharArray();
            for (int i = 0; i < vs.Length; i++)
            {
                char c = vs[i];
                if (c=='('||c=='['||c=='{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count==0)
                    {
                        return false;
                    }
                    else
                    {
                        char topchar = stack.Pop();
                        if (c==')'&& topchar!='(')
                        {
                            return false;
                        }
                        if(c==']' && topchar != '[')
                        {
                            return false;
                        }
                        if (c=='}' && topchar != '{')
                        {
                            return false;
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

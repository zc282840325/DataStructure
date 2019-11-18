using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
   public class ArrayStack2
    {
        private int maxsize;//声明栈的长度
        private int top = -1;//栈顶
        private int[] stack;
        //构造器
        public ArrayStack2(int maxsize)
        {
            this.maxsize = maxsize;
            stack = new int[maxsize];
        }
        //栈满
        public bool isFull()
        {
            return top == maxsize - 1;
        }
        //栈空
        public bool isEmpty()
        {
            return top == -1;
        }
        //入栈-push
        public void push(int n)
        {
            if (isFull())
            {
                Console.WriteLine("栈满，无法添加！");
                return;
            }
            top++;
            stack[top] = n;
        }
        //出栈-pop
        public int pop()
        {
            if (isEmpty())
            {
                throw new Exception("栈空，无法出栈！");
            }
            int value = stack[top];
            top--;
            return value;
        }
        //遍历栈
        public void showlist()
        {
            if (isEmpty())
            {
                throw new Exception("栈空，无法出栈！");
            }
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(pop());
            }
        }
        //返回运算符的优先级，优先级是程序员来确定。
        //优先级使用数字表示，数字越大优先级越高。
        public int priority(int oper)
        {
            if (oper=='*'||oper=='/')
            {
                return 1;
            }
            else if (oper == '+' || oper == '-')
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        //判断是不是一个运算符
        public bool isOper(char val)
        {
            return val == '+' || val == '-' || val == '*' || val == '/';
        }
        //计算方法
        public int cal(int num1,int num2,int oper)
        {
            int res = 0;
            switch (oper)
            {
                case '+':
                    res= num1 + num2;
                    break;
                case '-':
                    res = num2 - num1;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                default:
                    break;
            }
            return res;
        }
        //可以返回当前栈顶的值
        public int peek()
        {
            return stack[top];
        }
        
    }
}

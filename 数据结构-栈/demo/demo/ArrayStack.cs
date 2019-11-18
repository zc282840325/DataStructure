using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ArrayStack
    {
        private int maxsize;//声明栈的长度
        private int top = -1;//栈顶
        private int[] stack;
        //构造器
        public ArrayStack(int maxsize)
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
            int value=stack[top];
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
    }
}

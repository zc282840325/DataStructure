using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class LinkedStack
    {
        public Node head = new Node(-1);//虚拟头结点
        //链空
        public bool isEmpty()
        {
            return head.next == null;
        }
        //添加
        public void push(int n)
        {
            Node temp = new Node(n);
            Node temp2 = head;
                while (temp2.next != null)
                {
                    temp2 = temp2.next;
                }
                temp2.next = temp;
         
        }
        //删除
        public int pop()
        {
            Node temp =head;
            int value = 0;
            if (temp.next == null)
            {
                temp.next = null;
            }
            else
            {
                value = temp.next.no;
                temp.next = temp.next.next;
            }
            return value;
        }
        //展示列表
        public void showlist()
        {
            Node temp = head;
            if (isEmpty())
            {
                Console.WriteLine("栈空！");
            }
            while (temp.next!=null)
            {
                Console.WriteLine(pop());
                temp = temp.next;
            }
            Console.WriteLine(temp.no);
        } 
    }
    public class Node
    {
        public int no;
        public Node next;
        public Node(int no)
        {
            this.no = no;
        }
    }
}

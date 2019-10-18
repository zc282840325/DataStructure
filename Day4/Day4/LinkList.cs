using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
   public class LinkList<E>
    {
        private class Node {
            public E e;
            public Node next;

            public Node(E e, Node next) {
                this.e = e;
                this.next = next;
            }
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }
            public Node()
            {
                this.e = default(E);
                this.next = null;
            }
            public string ToString()
            {
                return e.ToString();
            }
        }
        private Node dummyHead;
        int size;
        public LinkList()
        {
            dummyHead = new Node();
            size = 0;
        }

        //获取链表中的元素个数
        public int getSize()
        {
            return size;
        }

        //返回数组是否为空
        public bool isEmpty()
        {
            return size == 0;
        }
        //获取链表中的元素个数
        public void addFirst(E e)
        {
            //Node node = new Node(e);
            //node.next = head;
            //head = node;
            add(0, e);
        }
        //在第index个位置插入一个新元素e
        public void add(int index,E e)
        {
            if (index<0||index>size)
            {
                Console.WriteLine("Add faille");
            }
          
                Node prev = dummyHead;
                for (int i = 0; i < index; i++)
                {
                    prev = prev.next;
                }
            prev.next = new Node(e, prev.next);
            size++;

        }

        public void addLast(E e)
        {
            add(size,e);
        }

        public E get(int index)
        {
            if (index < 0 || index >=size)
            {
                Console.WriteLine("Add faille");
            }
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }

        public E getFirst()
        {
            return get(0);
        }
        public E getLast()
        {
            return get(size-1);
        }
        public void set(int index,E e)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Add faille");
            }
            Node cur = dummyHead.next;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = e;
        }
        public bool contains(E e)
        {
            Node cur = dummyHead.next;
            while (cur!=null)
            {
                if (cur.e.ToString() == e.ToString())
                {
                    return true;
                }
                cur = cur.next;
            }
            return false;
        }

        public string ToString()
        {
            StringBuilder res = new StringBuilder();

            Node cur = dummyHead.next;
            while (cur!=null)
            {
                res.Append(cur.e+"->");
                cur = cur.next;
            }
             res.Append("NULL");
            return res.ToString();
        }
        public E remove(int index)
        {
            if (index < 0 || index >= size)
            {
                Console.WriteLine("Add faille");
            }
            Node prev = dummyHead;
            for (int i = 0; i < index; i++)
            {
                prev = prev.next;
            }
            Node retNode = prev.next;
            prev.next = retNode.next;
            retNode.next = null;
            size--;
            return retNode.e;
        }
        public E removeFirst()
        {
            return remove(0);
        }
        public E removeLast()
        {
            return remove(size-1);
        }


     

    }
}

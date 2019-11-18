using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dem5
{
   public class RingLink
    {
        Hero head = new Hero(1);
        Hero foot = new Hero(0);
        public Hero gethead()
        {
            return head;
        }
        public void add(int num)
        {
            Hero temp = head;
            if (num<2)
            {
                Console.WriteLine("数据太少！");
                return;
            }
            for (int i =2 ; i <=num; i++)
            {
                Hero node = new Hero(i);
                while (true)
                {
                    if (temp.next==null)
                    {
                        break;
                    }
                    temp = temp.next;
                }
                temp.next = node;
                if (i==num)
                {
                    node.next = head;
                    foot = node;
                }
            }
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="no">节点的值</param>
        public void del(int no)
        {
            Hero temp = gethead();
            if (no== temp.no)
            {
                if (head.next==foot)
                {
                    Change();
                }
                else
                {
                    temp = foot;
                    temp.next = temp.next.next;
                    head = temp.next;
                }
            }
            else
            {
                temp = getpre(head, no);
                temp.next = temp.next.next;
                Change();
            }
           
        }
        /// <summary>
        /// 只有2个节点的时候，直接出
        /// </summary>
        public void Change()
        {
            if (head.next == foot)
            {
                Console.Write(head);
                head = foot;
                head.next = null;
            }
        }
        /// <summary>
        /// 获取待删除节点的上一个节点
        /// </summary>
        /// <param name="temp">头节点的</param>
        /// <param name="no">要删除的节点</param>
        /// <returns></returns>
        public Hero getpre(Hero temp,int no)
        {
            while (true)
            {
                if (temp.next.no == no)
                {
                    break;
                }
                temp = temp.next;
            }
            if (temp.next==foot)
            {
                foot = temp;
            }
            return temp;
        }
        /// <summary>
        /// 获取链表的长度
        /// </summary>
        /// <returns></returns>
        public int getlength()
        {
            Hero temp = head;
            int num = 0;
            while (true)
            {
                num++;
                temp = temp.next;
                if (temp.no==head.no)
                {
                    break;
                }
            }
            return num;
        }
        /// <summary>
        /// 输出打印
        /// </summary>
        /// <param name="m">数m下</param>
        public void showlink(int m)
        {
            Hero temp = head;
            int num = 0;
            int leng = getlength();//获取链表的长度
            if (head == null)
            {
                Console.WriteLine("参数输入有误，请重新输入！");
                return;
            }
            while (true)
            {
                if (temp.next==null)
                {
                    break;
                }
                num++;
                if (num%m==0)
                {
                    Console.WriteLine(temp.no);
                    del(temp.no);
                }
                temp = temp.next;
            }
            Console.WriteLine(temp);
        }
        /// <summary>
        /// 老师思路的实现
        /// </summary>
        /// <param name="startNo">开始的编号</param>
        /// <param name="countNum">间隔个数（数几下）</param>
        /// <param name="nums">链表长度</param>
        public void countBoy(int startNo,int countNum,int nums)
        {
            //先对数据进行校验
            if (head==null||startNo<1||startNo>nums)
            {
                Console.WriteLine("参数输入有误，请重新输入！");
                return;
            }
            //创建辅助指针,小孩出圈
            Hero helper = head;//指向最有一个节点
            while (true)
            {
                if (helper.next==head)
                {
                    break;
                }
                helper = helper.next;
            }
            //小孩报数钱，先让head和helper移动k-1次
            for (int i = 0; i < startNo-1; i++)
            {
                head = head.next;
                helper = helper.next;
            }
            //当小孩报数时，让head和helper指针同时的移动m-1次，然后出圈
            //这里是一个循环，循环到只有一个节点的时候
            while (true)
            {
                if (helper==head)
                {
                    break;
                }
                //让head和helper指针同时的移动countNum - 1次
                for (int i = 0; i < countNum - 1; i++)
                {
                    head = head.next;
                    helper = helper.next;
                }
                Console.WriteLine("小孩出圈:"+head.no);
                //将head指向的小孩出圈
                head = head.next;
                helper.next = head;
            }
            Console.WriteLine("最后一个小孩:"+ head.no);
        }
    }
    public class Hero
    {
        public int no;
        public Hero next;

        public Hero(int no)
        {
            this.no = no;
        }

        public override string ToString()
        {
            return  no+"\r\n";
        }
    }
}

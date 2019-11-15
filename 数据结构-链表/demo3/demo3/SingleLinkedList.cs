using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    public class SingleLinkedList
    {
        //初始化一个头结点，头结点不要动，不存放具体的数据
        private HeroNode head = new HeroNode(0, "", "");
        //添加节点到单向链表
        //思路，当不考虑编号顺序是
        //1.找到当前链表的最后节点
        //2.将最后这个节点的next指向新的节点
        public void add(HeroNode heroNode)
        {
            //因为head节点不能动，因此我们需要一个辅助遍历temp
            HeroNode temp = head;
            //遍历链表，找到最后
            while (true)
            {
                //找到链表的最后
                if (temp.next == null)
                {
                    break;
                }
                //如果没有找到最后
                temp = temp.next;
            }
            //当退出while循环时，temp就指向了链表的最后
            temp.next = heroNode;
        }
        //显示链表
        public void showLink()
        {
            if (head.next == null)
            {
                Console.WriteLine("链表为空！");
            }
            //因为头结点不能懂，我们需要一个辅助变量来遍历
            HeroNode temp = head.next;
            while (true)
            {
                //找到链表的最后
                if (temp.next == null)
                {
                    Console.WriteLine(temp);
                    break;
                }
                Console.WriteLine(temp);
                //将temp后移
                temp = temp.next;
            }
        }
        //第二种方式在添加英雄的时候，根据排名将英雄插入到指定位置
        //如果有这个排名，则添加失败
        public void addByOrder(HeroNode heroNode)
        {
            HeroNode temp = head;
            bool flag = false;//标志添加的编号是否存在，默认为false
            while (true)
            {
                if (temp.next == null)//说明temp已经在链表的最后
                {
                    break;
                }
                if (temp.next.no > heroNode.no)//位置找到，就在temp后面插入
                {
                    break;

                }
                else if (temp.next.no == heroNode.no)
                {
                    flag = true;//说明编号存在
                    break;
                }
                temp = temp.next;
            }
            //判断flag的值，如果flag==true,说明编号存在
            if (flag)
            {
                Console.WriteLine("准备插入的英雄的编号{0}已经存在了，不能加入\n", heroNode.no);
            }
            else
            {
                //插入到temp后面
                heroNode.next = temp.next;
                temp.next = heroNode;
            }
        }

        public HeroNode getHead()
        {
            return head;
        }

        //修改结点的信息，根据编号no来修改，即no编号不能改
        public void update(HeroNode newheroNode)
        {
            if (head.next == null)
            {
                Console.WriteLine("链表为空！");
            }
            else
            {
                HeroNode temp = head;
                bool flag = false;//是否找到该结点
                while (true)
                {
                    if (temp == null)
                    {
                        break;
                    }
                    if (temp.no == newheroNode.no)
                    {
                        //找到
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (flag)
                {
                    temp.name = newheroNode.name;
                    temp.nickname = newheroNode.nickname;
                }
                else
                {
                    Console.WriteLine("没有找到编号{0}的结点，不能修改\n", newheroNode.no);
                }
            }
        }
        //删除结点
        public void delete(int n)
        {
            if (head.next == null)
            {
                Console.WriteLine("链表为空！");
            }
            else
            {
                HeroNode temp = head;
                bool flag = false;//是否找到该结点
                while (true)
                {
                    if (temp == null)
                    {
                        break;
                    }
                    if (temp.no == n - 1)
                    {
                        //找到
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (flag)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    Console.WriteLine("没有找到编号{0}的结点，不能修改\n", n);
                }
            }
        }
        //查询
        public void Select(int n)
        {
            if (head.next == null)
            {
                Console.WriteLine("链表为空！");
            }
            else
            {
                HeroNode temp = head;
                bool flag = false;//是否找到该结点
                while (true)
                {
                    if (temp == null)
                    {
                        break;
                    }
                    if (temp.no == n)
                    {
                        //找到
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (flag)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine("没有找到编号{0}的结点，不能修改\n", n);
                }
            }
        }
        //获取有效节点的个数
        public int getLength()
        {
            if (head.next==null)
            {
                return 0;
            }
            int length = 0;
            HeroNode temp = head;
            while (temp.next != null)
            {
                length++;
                temp = temp.next;
            }
            return length;
        }
        //查询单链表中的倒数第k个节点
        public void GetBackByOne(int k)
        {
            if (head.next == null)
            {
                Console.WriteLine("当前链表为空！");
            }
            int length = getLength();
            if (k>length||k<=0)
            {
                Console.WriteLine("您输入的个数超过了链表长度，无法查询！");
            }
            int num = length - k+1;
            HeroNode temp = head;
            for (int i = 0; i < num; i++)
            {
                temp = temp.next;
            }
            Console.WriteLine(temp);
        }

        #region 实现单链表的反转
        //实现单链表的反转
        public void fanzhuan()
        {
            if (head.next == null)
            {
                Console.WriteLine("当前链表为空！");
            }
            HeroNode temp = head;
            List<HeroNode> list = new List<HeroNode>();
            while (temp.next != null)
            {
                if (temp.no!=0)
                {
                    list.Add(temp);
                    temp = temp.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            list.Add(temp);
            head.next = null;
            for (int i = list.Count-1; i >=0; i--)
            {
                list[i].next = null;
                add(list[i]);
            }
        }
        public void fanzhuan2(HeroNode head)
        {
            if (head.next == null || head.next.next == null)
            {
                return;
            }
            HeroNode cur=head.next;//获取下一个节点
            HeroNode next = null;
            HeroNode reverseHead = new HeroNode(0, "", "");//新建一个节点
            while (cur.next != null)
            {
                next = cur.next;//取下一个节点
                change(ref reverseHead,cur);//插入新节点
                if (next == null)
                {
                    break;
                }
                cur = next;//遍历下个节点
            }
            change(ref reverseHead, next);
            //将头节点替换一下大功完成！！！
            head.next = reverseHead.next;
        }
        public void change(ref HeroNode reverseHead,HeroNode cur)
        {
            HeroNode next = null;
            next = reverseHead.next;
            reverseHead.next = cur;
            cur.next = next;
        }
        #endregion

        #region 从尾到头打印单链表
        public void Print()
        {
            if (head.next == null)
            {
                Console.WriteLine("当前链表为空！");
            }
            Stack<HeroNode> nodes = new Stack<HeroNode>();
            HeroNode temp = head.next;
            while (temp.next!=null)
            {
                nodes.Push(temp);
                temp = temp.next;
            }
            nodes.Push(temp);

            int count = nodes.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(nodes.Pop());
            }
        }
        #endregion

        #region 合并2个有序的链表
        public void hebing(SingleLinkedList reverseHead,ref SingleLinkedList reverseHead2)
        {
            HeroNode hero = reverseHead.getHead().next;
            reverseHead2.add(hero);
        } 
        #endregion
    }


    public class HeroNode
    {
        public int no;
        public string name;
        public string nickname;
        public HeroNode next;//指向下一个节点
        //构造器
        public HeroNode(int no, string name, string nickname)
        {
            this.no = no;
            this.name = name;
            this.nickname = nickname;
        }
        //为了现实方法，我们重新toString
        public override string ToString()
        {
            return "HeroNode[no=" + no + ",name=" + name + ",nickname=" + nickname + "]";
        }
    }
}

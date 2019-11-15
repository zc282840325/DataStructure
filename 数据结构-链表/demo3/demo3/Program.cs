using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //进行测试
            //先创建节点
            HeroNode hero1 = new HeroNode(1,"宋江","及时雨");
            HeroNode hero2 = new HeroNode(2, "卢俊义", "玉麒麟");
            HeroNode hero3 = new HeroNode(3, "吴用", "智多星");
            //HeroNode hero4 = new HeroNode(4, "林冲", "豹子头");
            //HeroNode hero5 = new HeroNode(5, "李逵", "黑旋风");
            //HeroNode hero6 = new HeroNode(6, "李逵1", "黑旋风1");
            //创建链表
            SingleLinkedList single = new SingleLinkedList();
            //加入
            //single.add(hero1);
            //single.add(hero4);
            //single.add(hero2);
            //single.add(hero3);
            //加入的时候按照编号的顺序
            single.addByOrder(hero1);
      
            single.addByOrder(hero2);
            single.addByOrder(hero3);
            //single.addByOrder(hero4);
            //single.addByOrder(hero5);
            //single.addByOrder(hero6);
            //测试修改结点
            single.showLink();

            //HeroNode hero5 = new HeroNode(2, "卢俊义2", "玉麒麟2");
            //single.update(hero5);
            //Console.WriteLine("修改之后的链表情况---");
            //single.showLink();
            //删除结点
            single.delete(2);
            single.delete(3);
            single.delete(1);
            Console.WriteLine("删除2号结点");
            single.showLink();
            //查询
            Console.WriteLine("查询3号结点内容");
          //  single.Select(3);
            //查询有效数据
            Console.WriteLine("查询有效数据的个数：{0}", single.getLength());
            //查询单链表中的倒数第k个节点
            Console.WriteLine("查询单链表中的倒数第k个节点:");
            single.GetBackByOne(2);
            //单链表的反转
            Console.WriteLine("单链表的反转：");
            single.fanzhuan2(single.getHead());
            single.showLink();
            //从尾到头打印单链表
            Console.WriteLine("从尾到头打印单链表:");
            single.Print();
            Console.WriteLine("合并两个单链表：");
            SingleLinkedList reverseHead = new SingleLinkedList();//新建一个节点
            HeroNode hero4 = new HeroNode(4, "林冲", "豹子头");
            HeroNode hero5 = new HeroNode(5, "李逵", "黑旋风");
            HeroNode hero6 = new HeroNode(6, "李逵1", "黑旋风1");
            reverseHead.addByOrder(hero4);
            reverseHead.addByOrder(hero5);
            reverseHead.addByOrder(hero6);
            single.hebing(reverseHead,ref single);
            single.showLink();
            Console.ReadKey();
        }
    }
}

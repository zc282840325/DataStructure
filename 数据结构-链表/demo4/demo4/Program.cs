using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("双向链表的测试：");
            HeroNode hero1 = new HeroNode(1, "宋江", "及时雨");
            HeroNode hero2 = new HeroNode(2, "卢俊义", "玉麒麟");
            HeroNode hero3 = new HeroNode(3, "吴用", "智多星");
            HeroNode hero4 = new HeroNode(4, "林冲", "豹子头");
            DoubleLinkedList linkedList = new DoubleLinkedList();
            Console.WriteLine("添加元素：");
            linkedList.add(hero1);
            linkedList.add(hero3);
            linkedList.add(hero4);

            Console.WriteLine("打印：");
            linkedList.add(hero2);
            HeroNode hero5 = new HeroNode(3, "吴用2", "智多星2");
            linkedList.update(hero5);
            linkedList.showLink();
            Console.WriteLine("修改后的：");
            linkedList.delete(2);
            Console.WriteLine("删除2之后的：");
            linkedList.showLink();
            HeroNode hero6 = new HeroNode(2, "卢俊义", "玉麒麟");
            linkedList.addByOrder(hero6);
            Console.WriteLine("添加一个2");
            linkedList.showLink();
            Console.ReadKey();
        }
    }
}

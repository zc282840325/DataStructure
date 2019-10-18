using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> linkList = new LinkList<int>();
            for (int i = 0; i < 5; i++)
            {
                linkList.addFirst(i);
                Console.WriteLine(linkList.ToString());
            }

            linkList.add(3, 666);
            Console.WriteLine(linkList.ToString());

            linkList.removeFirst();
            Console.WriteLine(linkList.ToString());

            linkList.removeLast();
            Console.WriteLine(linkList.ToString());
        }
    }
}

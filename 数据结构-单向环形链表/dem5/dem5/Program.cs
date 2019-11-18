using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dem5
{
    class Program
    {
        static void Main(string[] args)
        {
            RingLink link = new RingLink();
            link.add(5);
            link.countBoy(1,3,5);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5

{
    class Program
    {
        static void Main(string[] args)
        {
            BST<int> sT = new BST<int>();

            for (int i = 0; i < 10; i++)
            {
                sT.add(i);
            }

        }
    }
}

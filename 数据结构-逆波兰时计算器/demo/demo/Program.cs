using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "(30+4)*5-6";
            string str2 = "4*5-8+60+8/2";

            string suffixExpression = "30 4 + 5 * 6 -";
            suffixExpression = "4 5 * 8 - 60 + 8 2 / +";
            PolandNotation poland = new PolandNotation();
            List<string> list = poland.getListString(suffixExpression);
            Console.WriteLine(poland.calculate(list));
        }
    }
}

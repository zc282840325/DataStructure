using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {


            // Array<int> arr = new Array<int>(20);
            // for (int i = 0; i < 10; i++)
            //     arr.addLast(i);
            //Console.WriteLine(arr.ToString());

            // arr.add(1,100);
            // Console.WriteLine(arr.ToString());

            // arr.addFirst(-1);
            // Console.WriteLine(arr.ToString());

            // arr.addLast(-1);
            // Console.WriteLine(arr.ToString());

            // Console.WriteLine(arr.remove(1));
            // Console.WriteLine(arr.ToString());

            // arr.removeFirst();
            // Console.WriteLine(arr.ToString());

            // arr.removeLast();
            // Console.WriteLine(arr.ToString());

            // arr.removeElement(5);
            // Console.WriteLine(arr.ToString());

            //Array<Student> arr = new Array<Student>();
            //arr.addLast(new Student("Alice", 100));
            //arr.addLast(new Student("Bob", 66));
            //arr.addLast(new Student("Charlie", 68));

            //for (int i = 0; i < arr.getSize(); i++)
            //{
            //    Console.WriteLine(arr.get(i).ToString());
            //}

            Array<int> arr = new Array<int>();
            for (int i = 0; i < 10; i++)
                arr.addLast(i);
            Console.WriteLine(arr.ToString());
            arr.add(1,100);
            Console.WriteLine(arr.ToString());
            arr.addFirst(-1);
            Console.WriteLine(arr.ToString());
         
            arr.remove(1);
            Console.WriteLine(arr.ToString());
            arr.removeFirst();
            Console.WriteLine(arr.ToString());
            arr.removeLast();
            Console.WriteLine(arr.ToString());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
   public class Student
    {
        private string name;
        private int score;
        public Student(string studentname,int studentscore)
        {
            name = studentname;
            score = studentscore;
        }

        public string ToString()
        {
            return string.Format("Student(name:{0},score:{1})",name,score);
        }

        public static void main(string[] vs)
        {
            Array<Student> arr = new Array<Student>();
            arr.addLast(new Student("Alice",100));
            arr.addLast(new Student("Bob", 66));
            arr.addLast(new Student("Charlie", 68));
        }
    }
}

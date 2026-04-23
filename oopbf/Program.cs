using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int x, y;
            str = Console.ReadLine();
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Student s = new Student(str, x, y);
           
        }
    }
}

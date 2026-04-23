using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbf
{
    internal class Student
    {
        private string name;
        private int age;
        private double grade;
        public Student(string n, int a, double g)
        {
            this.name = n;
            Console.WriteLine("Name: " + name);

            if (a > 5)
            {
                this.age = a;
                Console.WriteLine("Age: " + age);
            }
            else Console.WriteLine("Invalid age!");

            if (g >= 0 && g <= 100)
            {
                this.grade = g;
                Console.WriteLine("Grade: " + grade);
            }
            else Console.WriteLine("Invalid grade!");
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            this.name = n;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int a)
        {
          this.age = a;
        }

        public double GetGrade()
        {
            return grade;
        }

        public void SetGrade(double g)
        {
          this.grade = g;
        }
    }
}

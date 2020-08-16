using System;
using System.Collections.Generic;
using System.Text;

namespace RCS_08._15_Student
{
    class Student
    {
        public String name;
        public String lastName;
        public int age;

 
        public Student(String name, String lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine(name + "  " + lastName + "  " + age);
        }
    }
}

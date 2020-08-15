using System;
using System.Collections.Generic;

namespace RCS_08._15_Student
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Student> students = new List<Student>();

            Student st1 = new Student("Ivans", "Ivanovs", 21);
            Student st2 = new Student("Janis", "Jansons", 23);
            Student st3 = new Student("Ieva", "Ievina", 20);
            Student st4 = new Student("Peteris", "Petrovs", 31);
            Student st5 = new Student("Egors", "Egorovs", 31);
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);

            PrintStud(students);
            FileIO.SaveToFile(students);

            List<Student> studentsNew = FileIO.LoadFromFile();
            PrintStud(studentsNew);
        }

        private static void PrintStud(List<Student> st)
        {
            for(int i = 0; i < st.Count; i++)
            {
                Console.WriteLine(st[i].lastName + "  " + st[i].name + "  " + st[i].age);
            }
                
        }
    }
}

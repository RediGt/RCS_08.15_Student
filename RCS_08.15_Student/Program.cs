using System;
using System.Collections.Generic;

namespace RCS_08._15_Student
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Student> studentsA = new List<Student>();

            Student st1 = new Student("Ivans", "Ivanovs", 21);
            Student st2 = new Student("Janis", "Jansons", 23);
            Student st3 = new Student("Ieva", "Ievina", 20);
            Student st4 = new Student("Peteris", "Petrovs", 31);
            Student st5 = new Student("Egors", "Egorovs", 31);
            studentsA.Add(st1);
            studentsA.Add(st2);
            studentsA.Add(st3);
            studentsA.Add(st4);
            studentsA.Add(st5);

            Console.WriteLine("Created list of students:");
            PrintStud(studentsA);
            FileIO.SaveToFile(studentsA);

            Console.WriteLine("\nLoaded list of students:");
            List<Student> studentsB = FileIO.LoadFromFile();
            PrintStud(studentsB);
            Console.WriteLine();
        }

        private static void PrintStud(List<Student> list)
        {
            foreach (var student in list)
                student.PrintInfo();              
        }
    }
}

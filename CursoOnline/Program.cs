using System;
using CursoOnline.Entities;
using System.Collections.Generic;

namespace CursoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                students.Add(new Student { Cod = cod });
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                students.Add(new Student { Cod = cod });
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                students.Add(new Student { Cod = cod });
            }
            Console.WriteLine();
            Console.WriteLine($"Total students: {students.Count}");
        }
    }
}

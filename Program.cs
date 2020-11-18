using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("````````````````*****```````````````````");
            Console.WriteLine("Welcome to University Management System");
            Console.WriteLine("Created By A. S. M. Radwan");
            Console.WriteLine("Developer At Kuratoli Software Solutions");
            Console.WriteLine("````````````````*****```````````````````");
            Console.WriteLine("````````````````````````````````````````");
            Course c = new Course("C#",001,3,5.0,1);
            Course c1 = new Course("C++", 003, 3, 5.0, 1);
            Section s = new Section("I","C#", 001,3, 5.0);
            Section s1 = new Section("J", "C#", 001, 3, 5.0);
            Section s2 = new Section("K", "C#", 001, 3, 5.0);
            Section s3 = new Section("L", "C#", 001, 3, 5.0);
            Section s4 = new Section("M", "C#", 001, 3, 5.0);
            Section s5= new Section("I", "OOP1", 002, 3, 5.0);
            Section s6 = new Section("J", "OOP1", 002, 3, 5.0);
            Section s7 = new Section("K", "OOP1", 002, 3, 5.0);
            Section s8 = new Section("L", "OOP1", 002, 3, 5.0);
            Section s9 = new Section("M", "OOP1", 002, 3, 5.0);
            s.SearchSection(001);
            Console.WriteLine("``````````Seacrhing For Section`````````");
            c.SearchSection(001);
            Console.WriteLine("````````````````````````````````````````");
            c.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            s.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            Departments d = new Departments("FST");
            d.AddCourse(c1,c);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("``````Adding Courses In Department``````");
            d.AddCourse(s, s1, s2, s3,s4,s5,s6,s7,s8,s9);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("`````````Faculty Taking Courses`````````");

        }
    }
}

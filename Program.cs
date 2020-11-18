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
            Section s1 = new Section("J", "C#", 001, 3, 3.0);
            Section s2 = new Section("K", "C#", 001, 3, 3.0);
            Section s3 = new Section("L", "C#", 001, 3, 3.0);
            Section s4 = new Section("M", "C#", 001, 3, 3.0);
            Section s5= new Section("I", "OOP1", 002, 3, 3.0);
            Section s6 = new Section("J", "OOP1", 002, 3, 3.0);
            Section s7 = new Section("K", "OOP1", 002, 3, 3.0);
            Section s8 = new Section("L", "OOP1", 002, 3, 3.0);
            Section s9 = new Section("M", "OOP1", 002, 3, 3.0);
            s.SearchSection(001);
            Console.WriteLine("``````````Seacrhing For Section`````````");
            c.SearchSection(001);
            Console.WriteLine("````````````````````````````````````````");
            c.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            s.ShowInfo();
            Console.WriteLine("````````````````````````````````````````");
            Departments d = new Departments("FST");
            Departments d1 = new Departments("FE");
            Departments d2 = new Departments("FBA");
            Departments d3 = new Departments("FASS");
            d.AddCourse(c1,c);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("``````Adding Courses In Department``````");
            d.AddCourse(s, s1, s2, s3,s4,s5,s6,s7,s8,s9);
            d.ShowAllCourses();
            Console.WriteLine("````````````````````````````````````````");
            Console.WriteLine("`````````Faculty Taking Courses`````````");
            Faculty f = new Faculty("Dennis Ritchie", "20-001");
            Faculty f1 = new Faculty("Bjarne Stroustrup", "20-002");
            Faculty f2= new Faculty("James Gosling", "20-003");
            Faculty f3 = new Faculty("Linus Torvalds", "20-004");
            Faculty f4 = new Faculty("Anders Hejlsberg", "20-005");
            Teaching_Hour t = new Teaching_Hour("C programming language", 3,d);
            Teaching_Hour t1 = new Teaching_Hour("C++ programming language", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("Java programming language", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("Python", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("OS", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("OOAD", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("Accounting", 3, d2);
            Teaching_Hour t7 = new Teaching_Hour("COA", 3, d);
            Teaching_Hour t8 = new Teaching_Hour("DC", 3, d1);
            Teaching_Hour t9 = new Teaching_Hour("DLD", 3, d1);
            Teaching_Hour t10 = new Teaching_Hour("AC", 3, d1);
            Teaching_Hour t11 = new Teaching_Hour("DEC", 3, d1);
            Teaching_Hour t12 = new Teaching_Hour("ECO", 3, d2);
            Teaching_Hour t13 = new Teaching_Hour("BUSS MATH", 3, d2);
            Teaching_Hour t14 = new Teaching_Hour("BUSS COMM", 3, d2);
            Teaching_Hour t15 = new Teaching_Hour("AC", 3, d3);
            Teaching_Hour t16 = new Teaching_Hour("DEC", 3, d3);
            Teaching_Hour t17 = new Teaching_Hour("DEC", 3, d3);
            Teaching_Hour t18 = new Teaching_Hour("AI", 3, d);
            Teaching_Hour t19 = new Teaching_Hour("SE", 3, d);
            Teaching_Hour t20 = new Teaching_Hour("SQT", 3, d);
            Console.WriteLine("``````````Faculty Information```````````");
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5,t18);
            f.ShowAllCredits();
            Console.WriteLine("``````````Faculty Information```````````");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5, t18,t19);
            f1.ShowAllCredits();


        }
    }
}

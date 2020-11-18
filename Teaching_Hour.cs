using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Teaching_Hour
    {
        public string CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public Departments Departments { get; set; }
        Course[] courses;
        public int CreditCount { get; set; }
        public Teaching_Hour()
        {
            courses = new Course[5];
        }
        public Teaching_Hour(string courseName, int courseCreditNumber, Departments departments)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Departments = departments;
            courses = new Course[5];
        }
        public void AddTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 7)
                    this.courses[CreditCount++] = course;
            }
            
        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}

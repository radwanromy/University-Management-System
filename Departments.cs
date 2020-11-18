using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Departments
    {
        public string DepartmentName { get; set; }
        Course[] listOfCourses;
        public int totalCourse { get; set; }
        public Section Section { get; set; }
        Teaching_Hour[] teachingHours;
        public int CreditCount { get; set; }
        public Departments()
        {
            listOfCourses = new Course[100];
            teachingHours = new Teaching_Hour[1000];
        }
        public Departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new Course[100];
            teachingHours = new Teaching_Hour[1000];


        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: " + DepartmentName);
            Console.WriteLine("Total : " + totalCourse);
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                    listOfCourses[totalCourse++] = course;
            }
        }
        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < totalCourse; i++)
            {
                if (course.CourseId.Equals(listOfCourses[i].CourseId))
                {
                    for (int j = i; j < totalCourse - 1; j++)
                    {
                        listOfCourses[j] = listOfCourses[j + 1];
                    }
                    totalCourse--;
                    break;
                }

            }
        }
        public void AddNewCourseNumber(Course course, int number)
        {
            course.AddCourseNumber(number);
        }
        public Course SearchCourse(string id)
        {
            Course b = null;
            for (int i = 0; i < totalCourse; i++)
            {
                if (listOfCourses[i].CourseId.Equals(id))
                {
                    b = listOfCourses[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowInfo();
            }
        }
        public void AddTeachingHours(Teaching_Hour teachingHour)
        {
            teachingHours[CreditCount++] = teachingHour;
        }
        public void ShowAllCredits()
        {
            
            for (int i = 0; i < CreditCount; i++)
            {
                Console.WriteLine("****************Department Info*************");
                teachingHours[i].Departments.ShowInfo();
                Console.WriteLine("****************Teaching  Hours*************");
                teachingHours[i].ShowInfo();
                Console.WriteLine("---------------------------------");
            }
            
        }
        

    }
}

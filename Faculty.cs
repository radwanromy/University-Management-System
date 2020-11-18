using System;
using System.Collections.Generic;
using System.Text;

namespace University_Management_System
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public string FacultyId { get; set; }
        Teaching_Hour[] teaching_Hours;
        public int CreditCount { get; set; }
        public Faculty()
        {
            teaching_Hours = new Teaching_Hour[100];
        }
        public Departments Departments { get; set; }
        
        public Faculty(string facultyName, string facultyId)
        {
            this.FacultyName = facultyName;
            this.FacultyId = facultyId;
            teaching_Hours = new Teaching_Hour[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + FacultyName);
            Console.WriteLine("Id: " + FacultyId);
        }
        public void AddCredit(params Teaching_Hour[] teaching_Hour)
        {
            foreach (var a in teaching_Hour)
            {
                if (CreditCount < 7)
                {
                    this.teaching_Hours[CreditCount++] = a;
                   
                }
                else
                {
                    Console.WriteLine("Cannot take any more course credit : " + a.CreditCount);
                }

            }
            Console.WriteLine("***||You Can Take Maximum 21 Credits||***");

        }
        public void ShowAllCredits()
        {
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < CreditCount; i++)
            {
                teaching_Hours[i].ShowInfo();
            }
            Console.WriteLine("---------------------------------");
        }
    }
}

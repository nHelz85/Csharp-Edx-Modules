using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Four Assignment.
// Author: Javier Herrero Arnanz.

namespace Module4
{
    class MyProgram
    {
        public struct Student
        {
            // Student variables.
            public string studentFirstName;
            public string studentLastName;
            public DateTime studentBirthdate;
            public string studentAddress;
            public string studentCity;
            public string studentStateProvince;
            public string studentZipCode;
            public string studentCountry;

            // Student constructor.
            public Student(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zipCode, string country)
            {
                this.studentFirstName = firstName;
                this.studentLastName = lastName;
                this.studentBirthdate = birthday;
                this.studentAddress = address;
                this.studentCity = city;
                this.studentStateProvince = state;
                this.studentZipCode = zipCode;
                this.studentCountry = country;
            }
        }

        public struct Teacher
        {
            // Teacher variables.
            public string teacherFirstName;
            public string teacherLastName;
            public DateTime teacherBirthdate;
            public string teacherAddress;
            public string teacherCity;
            public string teacherStateProvince;
            public string teacherZipCode;
            public string teacherCountry;

            public Teacher(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zipCode, string country)
            {
                this.teacherFirstName = firstName;
                this.teacherLastName = lastName;
                this.teacherBirthdate = birthday;
                this.teacherAddress = address;
                this.teacherCity = city;
                this.teacherStateProvince = state;
                this.teacherZipCode = zipCode;
                this.teacherCountry = country;
            }
        }
        public struct UProgram
        {
            public string programName;
            public string departmentHead;
            public string degrees;

            public UProgram(string nameOfProgram, string headOfDept, string degreesOffered)
            {
                this.programName = nameOfProgram;
                this.departmentHead = headOfDept;
                this.degrees = degreesOffered;
            }
        }
        public struct Course
        {
            public string courseName;
            public int courseCredits;
            public int courseDuration;
            public string courseTeacher;

            public Course(string nameOfCourse, int credits, int duration, string teacher)
            {
                this.courseName = nameOfCourse;
                this.courseCredits = credits;
                this.courseDuration = duration;
                this.courseTeacher = teacher;
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            Student student = new Student("Noalani", "Helmandottar", new DateTime(1985, 11, 17), "123 Blue Street", "Huntsville", "Alabama", "35806", "United States");
            students[0] = student;

            Console.WriteLine("Student First Name: " + students[0].studentFirstName);
            Console.WriteLine("Student Last Name: " + students[0].studentLastName);
            Console.WriteLine("Student Birthdate: " + students[0].studentBirthdate);
            Console.WriteLine("Student Address: " + students[0].studentAddress);
            Console.WriteLine("Student City: " + students[0].studentCity);
            Console.WriteLine("Student State: " + students[0].studentStateProvince);
            Console.WriteLine("Student Zip Code: " + students[0].studentZipCode);
            Console.WriteLine("Student Country: " + students[0].studentCountry);

            Console.Read();
        }
    }
}
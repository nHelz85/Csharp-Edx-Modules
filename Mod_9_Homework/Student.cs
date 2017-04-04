using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9_Homework
{
    class Student : Person, IComparable
    {
        //METHOD SPECIFIC TO STUDENT
        public void TakeTest()
        {
            Console.WriteLine("*****TAKING TEST*****");
        }

        public void addGrade(int grade)
        {
            grades.Push(grade);
        }

        //Create new stack object to store grades
        private Stack<int> grades;

        //CONSTANTS
        private static int studentCount = 0;

        //Constructor
        public Student(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zipCode, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthday;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Country = country;
            this.grades = new Stack<int>();
            studentCount++;
        }

        //COMPARE
        public int CompareTo(object obj)
        {
            Student studentCompare = (Student)obj;
            string nameCompare = studentCompare.FirstName + " " + studentCompare.LastName;
            string name = this.FirstName + " " + this.LastName;
            return (name.CompareTo(nameCompare));
        }
    }
}

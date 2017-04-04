using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
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
        public Student(string firstName, string lastName, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
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

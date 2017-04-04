using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8   
{
    class Course
    {
        //Constants
        private const int maxStudentNumber = 3;
        private const int maxTeacherNumber = 3;

        //Course Variables
        private string courseName;
        private int courseCredits;
        private int durationInWeeks;
        private string courseTeacher;

        //Student List
        private List<Student> studentList;

        //Teacher List
        private List<Teacher> teacherList;

        //Course Constructor
        public Course(string name, int credits, int duration)
        {
            this.courseName = name;
            this.courseCredits = credits;
            this.durationInWeeks = duration;
            this.studentList = new List<Student>(maxStudentNumber);
            this.teacherList = new List<Teacher>(maxTeacherNumber);
        }

        //Course Properties
        public string CourseName
        {
            get { return this.courseName; }
            set { this.courseName = value; }
        }
        public int CourseCredits
        {
            get { return this.courseCredits; }
            set { this.courseCredits = value; }
        }
        public int CourseDuration
        {
            get { return this.durationInWeeks; }
            set { this.durationInWeeks = value; }
        }

        //Get List of Students
        public void listOfStudents()
        {
            this.studentList.Sort();
            foreach (Student student in this.studentList)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);

            }
        }

        //Add student method
        public void addStudent(Student student)
        {
            int numStudents = this.studentList.Count;

            if (numStudents < maxStudentNumber)
            {
                this.studentList.Add(student);
            }
            else
            {
                Console.WriteLine("STUDENT ARRAY IS FULL");
            }
        }
        public void addTeacher(Teacher teacher)
        {
            int numTeachers = this.teacherList.Count;

            if (numTeachers < maxTeacherNumber)
            {
                this.teacherList.Add(teacher);
            }
            else
            {
                Console.WriteLine("TEACHER ARRAY IS FULL");
            }
        }
        public int getStudentNumber(Student student)
        {
            return this.studentList.Count();
        }
        public int getTeacherNumber(Teacher teacher)
        {
            return this.teacherList.Count();
        }
    }

}
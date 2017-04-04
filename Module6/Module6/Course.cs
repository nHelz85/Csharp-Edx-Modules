using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Course
    {
        //Constants
        private static int arraySize = 3;

        //Course Variables
        private string courseName;
        private int courseCredits;
        private int durationInWeeks;
        private string courseTeacher;
        private Student[] studentArray;
        private int studentCount;
        private Teacher[] teacherArray;
        private int teacherCount;

        //Course Constructor
        public Course(string name, int credits, int duration)
        {
            this.courseName = name;
            this.courseCredits = credits;
            this.durationInWeeks = duration;
            this.studentArray = new Student[arraySize];
            this.studentCount = 0;
            this.teacherArray = new Teacher[arraySize];
            this.teacherCount = 0;
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
        //read only
        public int StudentCount
        {
            get { return this.studentCount; }
        }
        public int TeacherCount
        {
            get { return this.teacherCount; }
        }

        //Add student method
        public void addStudent(Student student)
        {
            int numStudents = this.studentCount;

            if (numStudents < arraySize)
            {
                this.studentArray[numStudents] = student;
                this.studentCount++;
            }
            else
            {
                Console.WriteLine("STUDENT ARRAY IS FULL");
            }
        }
        public void addTeacher(Teacher teacher)
        {
            int numTeachers = this.teacherCount;

            if (numTeachers < arraySize)
            {
                this.teacherArray[numTeachers] = teacher;
                this.teacherCount++;
            }
            else
            {
                Console.WriteLine("TEACHER ARRAY IS FULL");
            }
        }
    }
}

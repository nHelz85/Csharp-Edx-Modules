using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate 3 student objects
            Student firstStudent = new Student("Noalani", "Helmandottar", new DateTime(1985, 11, 17), "123 Blue Street", "Huntsville", "Alabama", "35806", "United States");
            Student secondStudent = new Student("Kim", "Copelane", new DateTime(1990, 12, 12), "123 Green Street", "Huntsville", "Alabama", "35806", "United States");
            Student thirdStudent = new Student("AJ", "Kirby", new DateTime(1992, 12, 12), "123 Red Street", "Huntsville", "Alabama", "35806", "United States");

            //Instantiate course object
            Course course = new Course("Programming in C#", 4, 12);

            //add students to course
            course.addStudent(firstStudent);
            course.addStudent(secondStudent);
            course.addStudent(thirdStudent);

            //Instantiate 1 teacher object
            Teacher firstTeacher = new Teacher("Todd", "Beales", new DateTime(1980, 10, 10), "123 Yellow Street", "Huntsville", "Alabama", "35806", "United States");

            //add teacher to course object
            course.addTeacher(firstTeacher);

            //instantiate degree object
            Degree degree = new Degree("Bachelor of Science", 120, null);

            //add course to degree
            degree.Course = course;

            //instantiate UProgram object called Information Technology
            UProgram uProgram = new UProgram("Information Technology", "Tina Tucker", null);

            //add degree to uprogram
            uProgram.Degrees = degree;

            //output the name of the program and the degree it contains
            Console.WriteLine("The {0} program is ran by {1} and contains the {2} degree.", uProgram.ProgramName, uProgram.DepartmentHead, degree.DegreeName);
            Console.WriteLine("******************************************");
            //output name of the course in the degree
            Console.WriteLine("The {0} degree contains the course {1}.", degree.DegreeName, course.CourseName);
            Console.WriteLine("******************************************");
            //output the count of the number of students in the course.
            Console.WriteLine("The {0} course contains {1} student(s) so far.", course.CourseName, course.StudentCount);
            Console.WriteLine("******************************************");

            Console.Read();


        }
    }
}

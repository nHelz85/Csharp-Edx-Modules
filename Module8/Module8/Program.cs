using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate 3 student objects and add them to student list
            Student firstStudent = new Student("Lani", "Ach", new DateTime(1985, 11, 17), "123 Blue Street", "Huntsville", "Alabama", "35806", "United States");
            Student secondStudent = new Student("Kim", "Copeland", new DateTime(1990, 12, 12), "123 Green Street", "Huntsville", "Alabama", "35806", "United States");
            Student thirdStudent = new Student("AJ", "Kirby", new DateTime(1992, 12, 12), "123 Red Street", "Huntsville", "Alabama", "35806", "United States");
            List<Student> studentList = new List<Student>();
            studentList.Add(firstStudent);
            studentList.Add(secondStudent);
            studentList.Add(thirdStudent);


            //add 5 grades to stack for each student

            foreach (Student student in studentList)
            {
                for (int i = 0; i < 5; i++)
                {
                    int grade = i + 5;
                    student.addGrade(grade);
                }
            }

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

            course.listOfStudents();

            Console.Read();


        }
    }
}

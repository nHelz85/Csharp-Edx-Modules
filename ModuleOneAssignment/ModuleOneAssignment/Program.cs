using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdxPracticeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetDegreeInformation();
            GetProgramInformation();
            GetCourseInformation();

        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date: ");
            DateTime birthDate;
            DateTime.TryParse(Console.ReadLine(), out birthDate);
            IsStudentBirthdateValid(birthDate);
            PrintStudentDetails(firstName, lastName, birthDate);
        }
        static void PrintStudentDetails(string firstName, string lastName, DateTime birthDate)
        {
            Console.WriteLine("{0} {1} was born on: {2}", firstName, lastName, birthDate);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("What subject does this teacher specialize in? ");
            string teacherSubject = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, teacherSubject);
        }
        static void PrintTeacherDetails(string firstName, string lastName, string teacherSubject)
        {
            Console.WriteLine("{0} {1} specializes in: {2}", firstName, lastName, teacherSubject);
        }
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the name of the degree: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the school: ");
            string schoolName = Console.ReadLine();
            Console.WriteLine("Enter the total number of credits: ");
            int totalCredits = Convert.ToInt32(Console.ReadLine());

            PrintDegreeDetails(degreeName, schoolName, totalCredits);
        }
        static void PrintDegreeDetails(string degreeName, string schoolName, int totalCredits)
        {
            Console.WriteLine("The {0} degree at {1} requires a total of {2} credits", degreeName, schoolName, totalCredits);
        }
        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the name of the program: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the degree offered in this program: ");
            string degreeOffered = Console.ReadLine();
            Console.WriteLine("Enter the first name of the department head: ");
            string headFirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name of the department head: ");
            string headLastName = Console.ReadLine();

            PrintProgramDetails(programName, degreeOffered, headFirstName, headLastName);
        }
        static void PrintProgramDetails(string programName, string degreeOffered, string headFirstName, string headLastName)
        {
            Console.WriteLine("The {0} program offers a {1} and is headed by {2} {3}.", programName, degreeOffered, headFirstName, headLastName);
        }
        static void GetCourseInformation()
        {
            Console.WriteLine("Enter the name of the course: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the field of study: ");
            string studyField = Console.ReadLine();
            Console.WriteLine("Enter the course credits: ");
            int courseCredits = Convert.ToInt32(Console.ReadLine());

            PrintCourseDetails(courseName, studyField, courseCredits);
        }
        static void PrintCourseDetails(string courseName, string studyField, int courseCredits)
        {
            Console.WriteLine("The {0} course that's offered in the {1} is worth a total of {2} credits.", courseName, studyField, courseCredits);
        }
        private static bool IsStudentBirthdateValid(DateTime birthDate)
        {
            throw new NotImplementedException();
        }
        
    }
}

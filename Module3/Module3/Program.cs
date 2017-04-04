using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void GetStudentInformation()
        {
            Console.WriteLine("*******Enter student information below*******");
            Console.WriteLine("Student first name: ");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Student last name: ");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Student birthdate: ");
            DateTime studentBirthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Student street number : ");
            int studentHouseNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Student street name: ");
            string studentStreetName = Console.ReadLine();
            Console.WriteLine("Student city: ");
            string studentCity = Console.ReadLine();
            Console.WriteLine("Student state or province: ");
            string studentStateProvince = Console.ReadLine();
            Console.WriteLine("Student zip code: ");
            int studentZipCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Student country: ");
            string studentCountry = Console.ReadLine();

            PrintStudentDetails(studentFirstName, studentLastName, studentBirthdate, studentHouseNumber, studentStreetName,
                studentCity, studentStateProvince, studentZipCode, studentCountry);
        }
        static void PrintStudentDetails(string studentFName, string studentLName, 
            DateTime studentBDay, int studentHouseNum, string studentStName, 
            string studentCityName, string studentStateProv, 
            int studentZip, string studentCountryName)
        {
            Console.WriteLine("Student Name: {0} {1} \n Student Birthdate: {2} \n Student Address: {3} {4} \n {5}, {6} {7} \n {8}", studentFName, studentLName, studentBDay, studentHouseNum, studentStName, studentCityName, studentStateProv, studentZip, studentCountryName);
        }

        //Teacher Information
        static void GetTeacherInformation()
        {
            Console.WriteLine("*******Enter teacher information below*******");
            Console.WriteLine("Teacher first name: ");
            string teacherFirstName = Console.ReadLine();
            Console.WriteLine("Teacher last name: ");
            string teacherLastName = Console.ReadLine();
            Console.WriteLine("Teacher birthdate: ");
            DateTime teacherBirthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Teacher house number : ");
            int teacherHouseNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Teacher street name: ");
            string teacherStreetName = Console.ReadLine();
            Console.WriteLine("Teacher city: ");
            string teacherCity = Console.ReadLine();
            Console.WriteLine("Teacher state or province: ");
            string teacherStateProvince = Console.ReadLine();
            Console.WriteLine("Teacher zip code: ");
            int teacherZipCode = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Teacher country: ");
            string teacherCountry = Console.ReadLine();
            Console.WriteLine("Teacher's field of work: ");
            string fieldOfWork = Console.ReadLine();

            PrintTeacherDetails(teacherFirstName, teacherLastName, teacherBirthdate, teacherHouseNumber, teacherStreetName,
                teacherCity, teacherStateProvince, teacherZipCode, teacherCountry, fieldOfWork);
        }
        static void PrintTeacherDetails(string teacherFName, string teacherLName,
            DateTime teacherBDay, int teacherHouseNum, string teacherStName,
            string teacherCityName, string teacherStateProv,
            int teacherZip, string teacherCountryName, string teacherField)
        {
            Console.WriteLine("Teacher Name: {0} {1} \n Teacher Birthdate: {2} \n Teacher Address: {3} {4} \n {5}, {6} {7} \n {8} \n Teacher field: {9}",
                teacherFName, teacherLName, teacherBDay,
                teacherHouseNum, teacherStName, teacherCityName, 
                teacherStateProv, teacherZip, teacherCountryName, teacherField);
        }

        static void GetProgramDetails()
        {
            Console.WriteLine("*******Enter Program Information Below*******");
            Console.WriteLine("Program Name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Department Head");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Degrees Offered");
            string degrees = Console.ReadLine();

            PrintProgramDetails(programName, departmentHead, degrees);
        }
        
        static void PrintProgramDetails(string nameOfProgram, string departmentHeadName, string degreesOffered)
        {
            Console.WriteLine("Program Name: {0} \n Head of Department: {1} \n Degrees offered in this program: {2}", nameOfProgram, departmentHeadName, degreesOffered);
        }

        // Degree Information
        static void GetDegreeInformation()
        {
            Console.WriteLine("********Enter Degree Information Below*******");
            Console.WriteLine("Degree Name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Credits Required: ");
            int creditsRequired = Int32.Parse(Console.ReadLine());

            PrintDegreeDetails(degreeName, creditsRequired);
        }
        static void PrintDegreeDetails(string nameOfDegree, int requiredCredits)
        {
            Console.WriteLine("Degree Name: {0} \n Required Credits to Graduate: {1}", nameOfDegree, requiredCredits);
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("*******Enter Course Information Below*******");
            Console.WriteLine("Course Name: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Course Credits: ");
            int courseCredits = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Course Duration in weeks: ");
            int courseDuration = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Course Teacher: ");
            string courseTeacher = Console.ReadLine();

            PrintCourseDetails(courseName, courseCredits, courseDuration, courseTeacher);
        }
        static void PrintCourseDetails(string nameOfCourse, int creditsForCourse, int durationOfCourse, string courseTeacherName)
        {
            Console.WriteLine("Course Name: {0} \n Credits Upon Completion: {1} \n Course Duration: {2} weeks \n Course Teacher: {3}", nameOfCourse, creditsForCourse, durationOfCourse, courseTeacherName);
        }

        static DateTime ValidateBirthday()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();
            GetProgramDetails();
            GetDegreeInformation();
            GetCourseInformation();

            //validate birthday
            ValidateBirthday();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Information
            string studentFirstName;
            string studentLastName;
            DateTime studentBirthdate;
            string studentAddressLine1;
            string studentAddressLind2;
            string studentCity;
            string studentStateProvince;
            int studentZipCode;
            string studentCountry;

            studentFirstName = "Noalani";
            studentLastName = "Helmandottar";
            studentBirthdate = new DateTime(1985, 11, 17);
            studentAddressLine1 = "123 Blue Street";
            studentAddressLind2 = "";
            studentCity = "Huntsville";
            studentStateProvince = "Alabama";
            studentZipCode = 35806;
            studentCountry = "United States";

            Console.WriteLine("**********STUDENT INFORMATION***********");
            Console.WriteLine("STUDENT FIRST NAME: " + studentFirstName);
            Console.WriteLine("STUDENT LAST NAME: " + studentLastName);
            Console.WriteLine("STUDENT BIRTHDATE: " + studentBirthdate);
            Console.WriteLine("STUDENT ADDRESS: " + studentAddressLine1 + "\n" + studentAddressLind2 + "\n" + studentCity + ", " + studentStateProvince + " " + studentZipCode + " " + studentCountry);

            
            //Teacher Information
            string teacherFirstName;
            string teacherLastName;
            DateTime teacherBirthdate;
            string teacherAddressLine1;
            string teacherAddressLine2;
            string teacherCity;
            string teacherStateProvince;
            int teacherZipCode;
            string teacherCountry;

            teacherFirstName = "Noalani";
            teacherLastName = "Helmandottar";
            teacherBirthdate = new DateTime(1985, 11, 17);
            teacherAddressLine1 = "123 Blue Street";
            teacherAddressLine2 = "";
            teacherCity = "Huntsville";
            teacherStateProvince = "Alabama";
            teacherZipCode = 35806;
            teacherCountry = "United States";

            Console.WriteLine("**********TEACHER INFORMATION***********");
            Console.WriteLine("TEACHER FIRST NAME: " + teacherFirstName);
            Console.WriteLine("TEACHER LAST NAME: " + teacherLastName);
            Console.WriteLine("TEACHER BIRTHDATE: " + teacherBirthdate);
            Console.WriteLine("TEACHER ADDRESS: " + teacherAddressLine1 + "\n" + teacherAddressLine2 + "\n" + teacherCity + ", " + teacherStateProvince + " " + teacherZipCode + " " + teacherCountry);


            //UProgram Information
            string programName;
            string departmentHead;
            string degrees;

            programName = "Computer Science";
            departmentHead = "Tina Tucker";
            degrees = "Bachelor, Master";

            Console.WriteLine("**********PROGRAM INFORMATION***********");
            Console.WriteLine("PROGRAM NAME: " + programName);
            Console.WriteLine("DEPARTMENT HEAD: " + departmentHead);
            Console.WriteLine("DEGREES OFFERED: " + degrees);

            //Degree Information
            string degreeName;
            int creditsRequired;

            degreeName = "Bachelor of Science in Computer Science";
            creditsRequired = 120;

            Console.WriteLine("**********DEGREE INFORMATION***********");
            Console.WriteLine("DEGREE NAME: " + degreeName);
            Console.WriteLine("CREDITS REQUIRED TO GRADUATE: " + creditsRequired);

            //Course Information
            string courseName;
            int courseCredits;
            int durationInWeeks;
            string courseTeacher;

            courseName = "Introduction to Computer Science";
            courseCredits = 4;
            durationInWeeks = 12;
            courseTeacher = teacherFirstName + " " + teacherLastName;

            Console.WriteLine("**********COURSE INFORMATION***********");
            Console.WriteLine("COURSE NAME: " + courseName);
            Console.WriteLine("COURSE CREDITS: " + courseCredits);
            Console.WriteLine("COURSE DURATION: " + durationInWeeks);
            Console.WriteLine("COURSE TEACHER: " + courseTeacher);

        }
    }
}

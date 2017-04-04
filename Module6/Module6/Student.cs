using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
    {
        //Constants
        private static int studentCount = 0;

        //Variables
        private string studentFirstName;
        private string studentLastName;
        private DateTime studentBirthdate;
        private string studentAddress;
        private string studentCity;
        private string studentStateProvince;
        private string studentZipCode;
        private string studentCountry;
        

        //Constructor
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
            studentCount++;
        }

        //Properties
        public string StudentFirstName
        {
            get { return this.studentFirstName; }
            set { this.studentFirstName = value; }
        }
        public string StudentLastName
        {
            get { return this.studentLastName; }
            set { this.studentLastName = value; }
        }
        public DateTime StudentBirthdate
        {
            get { return this.studentBirthdate; }
            set { this.studentBirthdate = value; }
        }
        public string StudentAddress
        {
            get { return this.studentAddress; }
            set { this.studentAddress = value; }
        }
        public string StudentCity
        {
            get { return this.studentCity; }
            set { this.studentCity = value; }
        }
        public string StudentStateProvince
        {
            get { return this.studentStateProvince; }
            set { this.studentStateProvince = value; }
        }
        public string StudentZipCode
        {
            get { return this.studentZipCode; }
            set { this.studentZipCode = value; }
        }
        public string StudentCountry
        {
            get { return this.studentCountry; }
            set { this.studentCountry = value; }
        }
    }
}

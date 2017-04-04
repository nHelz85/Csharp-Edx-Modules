using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Teacher
    {

        //variables
        private string teacherFirstName;
        private string teacherLastName;
        private DateTime teacherBirthdate;
        private string teacherAddress;
        private string teacherCity;
        private string teacherStateProvince;
        private string teacherZipCode;
        private string teacherCountry;

        //Constructor
        public Teacher(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zipCode, string country)
        {
            this.teacherFirstName = firstName;
            this.teacherLastName = lastName;
            this.teacherBirthdate = birthday;
            this.teacherAddress = address;
            this.teacherCity = city;
            this.teacherStateProvince = state;
            this.teacherZipCode = zipCode;
            this.teacherCountry = country;
        }

        //Properties
        public string TeacherFirstName
        {
            get { return this.teacherFirstName; }
            set { this.teacherFirstName = value; }
        }
        public string TeacherLastName
        {
            get { return this.teacherLastName; }
            set { this.teacherLastName = value; }
        }
        public DateTime TeacherBirthdate
        {
            get { return this.teacherBirthdate; }
            set { this.teacherBirthdate = value; }
        }
        public string TeacherAddress
        {
            get { return this.teacherAddress; }
            set { this.teacherAddress = value; }
        }
        public string TeacherCity
        {
            get { return this.teacherCity; }
            set { this.teacherCity = value; }
        }
        public string TeacherStateProvince
        {
            get { return this.teacherStateProvince; }
            set { this.teacherStateProvince = value; }
        }
        public string TeacherZipCode
        {
            get { return this.teacherZipCode; }
            set { this.teacherZipCode = value; }
        }
        public string TeacherCountry
        {
            get { return this.teacherCountry; }
            set { this.teacherCountry = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    public class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("*****GRADING TEST*****");
        }

        //Constructor
        public Teacher(string firstName, string lastName, DateTime birthday, string address, string city, string state, string zipCode, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthdate = birthday;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.Country = country;
        }
    }
}

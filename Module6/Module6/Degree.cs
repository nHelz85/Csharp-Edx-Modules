using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Degree
    {
        //Variables
        private string degreeName;
        private int creditsRequired;
        private Course course;

        //Constructor
        public Degree(string name, int reqCredits, Course course)
        {
            this.degreeName = name;
            this.creditsRequired = reqCredits;
            this.course = course;
        }

        //Properties
        public string DegreeName
        {
            get { return this.degreeName; }
            set { this.degreeName = value; }
        }
        public int CreditsRequired
        {
            get { return this.creditsRequired; }
            set { this.creditsRequired = value; }
        }
        public Course Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
    }
}

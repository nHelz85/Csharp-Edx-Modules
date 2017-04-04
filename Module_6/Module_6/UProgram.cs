using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class UProgram
    {
        //Variables
        private string programName;
        private string departmentHead;
        private Degree degree;

        //Constructor
        public UProgram(string name, string head, Degree degree)
        {
            this.programName = name;
            this.departmentHead = head;
            this.degree = degree;
        }

        //Properties
        public string ProgramName
        {
            get { return this.programName; }
            set { this.programName = value; }
        }
        public string DepartmentHead
        {
            get { return this.departmentHead; }
            set { this.departmentHead = value; }
        }
        public Degree Degrees
        {
            get { return this.degree; }
            set { this.degree = value; }
        }
    }
}

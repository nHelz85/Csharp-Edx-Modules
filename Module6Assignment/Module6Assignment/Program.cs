using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Assignment
{

    public class Program
    {



        static void Main(string[] args)
        {
            
            Student student1 = new Student("Kim", "Copeland", "3.8", "United States", 35);
            Student student2 = new Student("Todd", "Beales", "3.9", "Canada", 30);
            Student student3 = new Student("Josh", "Bradshaw", "4.0", "Mexico", 36);
            
            Course course1 = new Course("Computer Science", "CompSci", 6);
            
            course1.students[0] = student1;
            course1.students[1] = student2;
            course1.students[2] = student3;
            
            Teacher teacher1 = new Teacher("Jason", "Terry", "Mathematics", "Africa", 40);
            
            course1.teachers[0] = teacher1;
            
            Degree degree1 = new Degree("Bachelor of Science", "CompSci");
            
            degree1.course = course1;
            
            SchoolProgram SchoolProgram1 = new SchoolProgram("Information Technology", "CompSci");
            
            SchoolProgram1.degreeType = degree1;
            
            Console.WriteLine("Students who complete the {0} program will receive the {1} degree.", SchoolProgram1.programName, SchoolProgram1.degreeType.degreeName);
            
            Console.WriteLine("The {0} degree involves the completion of the {1} course.", degree1.degreeName, degree1.course.courseName);
            
            Console.WriteLine("The {0} course has {1} student(s) enrolled as of today.", course1.courseName, Student.studentCount);
            
            Console.ReadLine();


        }
    }

    //Person base class

    public class Person
    {
        public string firstName
        {
            get;
            set;
        }
        
        public string lastName
        {
            get;
            set;
        }
        
        public int age
        {
            get;
            set;
        }
        
        public string country
        {
            get;
            set;
        }
    }

    //inheriting common attributes from person base class
    public class Student : Person
    {
        public string gradePointAverage
        {
            get; set;
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking test......");
        }



        public static int studentCount = 0;

        public Student(string studentFirstName, string studentLastName, string studentGPA, string studentCountry, int studentAge)
        {
            this.firstName = studentFirstName;
            this.lastName = studentLastName;
            this.gradePointAverage = studentGPA;
            this.country = studentCountry;
            this.age = studentAge;
            studentCount += 1;

        }

    }

    //inheriting common attributes from person base class
    public class Teacher : Person
    {
        public string field
        {
            get;
            set;
        }

        public void GradeTest()
        {
            Console.WriteLine("Grading test....");
        }


        public Teacher(string teacherFirstName, string teacherLastName, string teacherField, string teacherCountry, int teacherAge)
        {
            this.firstName = teacherFirstName;
            this.lastName = teacherLastName;
            this.age = teacherAge;
            this.country = teacherCountry;
            this.field = teacherField;
        }
    }

    public class SchoolProgram
    {
        public string programName
        {
            get;
            set;
        }
        
        public string programField
        {
            get;
            set;
        }
        
        public Degree degreeType
        {
            get;
            set;
        }

        public SchoolProgram(string programName, string programField)
        {
            this.programName = programName;
            this.programField = programField;

        }

        public SchoolProgram(Degree degreeType)
        {
            this.degreeType = degreeType;
        }

    }

    public class Degree
    {
        public string degreeName
        {
            get;
            set;
        }
        
        public string degreeField
        {
            get;
            set;
        }
        
        public Course course
        {
            get;
            set;
        }

        public Degree(string degreeName, string degreeField)
        {
            this.degreeName = degreeName;
            this.degreeField = degreeField;
        }

        public Degree(Course course)
        {
            this.course = course;
        }
    }

    public class Course
    {
        public string courseName
        {
            get;
            set;
        }

        int studentCount = 0;
        int teacherCount = 0;
        Student[] studentArray = new Student[3];
        Teacher[] teacherArray = new Teacher[3];

        public Student[] students
        {
            get { return studentArray; }
            set { studentArray = value; }
        }
        public Teacher[] teachers
        {
            get { return teacherArray; }
            set { teacherArray = value; }
        }
        public void Add(Student students)
        {
            studentArray[studentCount] = students;
            studentCount++;
        }
        // Method to add new teacher to this course.
        public void Add(Teacher teachers)
        {
            teacherArray[teacherCount] = teachers;
            teacherCount++;
        }


        public string courseField
        {
            get;
            set;
        }
        
        public int courseLength
        {
            get;
            set;
        }


        public Course(string courseName, string courseField, int courseLength)
        {
            this.courseName = courseName;
            this.courseField = courseField;
            this.courseLength = courseLength;
        }
    }




}

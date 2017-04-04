using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentList = new List<Student>();

        private int studentIndex;

        private const int startIndex = -1;


        public MainWindow()
        {
            InitializeComponent();

            studentIndex = startIndex;

            this.btnCreateStudent.Click += createStudentButton;
            this.btnNext.Click += nextStudentButton;
            this.btnPrevious.Click += previousStudentButton;
        }

        

        //Display student information
        void StudentInfo(Student student)
        {
            this.txtFirstName.Text = student.FirstName;
            this.txtLastName.Text = student.LastName;
            this.txtCity.Text = student.City;
        }

        void createStudentButton(object sender, RoutedEventArgs e)
        {
            studentList.Add(CreateNewStudent());
            ClearText();
        }

        void nextStudentButton(object sender, RoutedEventArgs e)
        {
            studentIndex += 1;
            CurrentStudentInfo();
        }

        void previousStudentButton(object sender, RoutedEventArgs e)
        {
            studentIndex -= 1;
            CurrentStudentInfo();
        }

        //Display Student Info
        void CurrentStudentInfo()
        {
            if(studentIndex >= studentList.Count)
            {
                studentIndex = 0;
            }
            else if(studentIndex < 0)
            {
                studentIndex = studentList.Count() - 1;
            }
            if (studentList.Any())
            {
                StudentInfo(studentList.ElementAt(studentIndex));
            }
        }

        //Create student
        Student CreateNewStudent()
        {
            studentIndex = startIndex;
            return new Student(this.txtFirstName.Text, this.txtLastName.Text, this.txtCity.Text);
        }
        
        void ClearText()
        {
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtCity.Text = "";
        }
        
    }
}

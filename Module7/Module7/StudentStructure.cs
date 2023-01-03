using System;
/**********************
 *Name: Student Structure
 * Author: Austin Mays
 * Created: 10/12/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: Program asks for student's first and last name, student ID, their major, and year of school.
 *
 Output: Program uses the struct Student to proceess and store the user input.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/
public struct Student
{
    public string firstName;
    public string lastName;
    public string studentID;
    public string major;
    public string yearInSchool;
}
namespace Structures
{
  
    class Program
    {

        static void Main(string[] args)
        {
            int counter = 0;
            int students = 3;
           
            if (counter < students)
            {
                Console.WriteLine("Please enter your information, new student: ");
                Console.WriteLine("Enter Your First Name: ");
                string f = Console.ReadLine();
                Console.WriteLine("Enter Your Last Name: ");
                string l = Console.ReadLine();
                Console.WriteLine("Enter Your Student ID: ");
                string id = Console.ReadLine();
                Console.WriteLine("Enter Your Major: ");
                string degree = Console.ReadLine();
                Console.WriteLine("Enter Your Year of School: ");
                string school = Console.ReadLine();
                createStudent(f, l, id, degree, school);
                displayStudent();
            }
            else if (counter == students)
            {
                Console.WriteLine("Submission Complete, Thank You!");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
        static void createStudent(string first, string last, string stud_id, string studies, string school_year)
        {
            Student welcome = new Student();
            welcome.firstName = first;
            welcome.lastName = last;
            welcome.studentID = stud_id;
            welcome.major = studies;
            welcome.yearInSchool = school_year;

            Console.WriteLine("First Name: ");
            first = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            last = Console.ReadLine();
            Console.WriteLine("Student ID: ");
            stud_id = Console.ReadLine();
            Console.WriteLine("Major: ");
            studies = Console.ReadLine();
            Console.WriteLine("Year of Schooling: ");
            school_year = Console.ReadLine();
        }
        static void displayStudent()
        {
            Student stud = new Student();
            stud.firstName = Console.ReadLine();
            stud.lastName = Console.ReadLine();
            stud.studentID = Console.ReadLine();
            stud.major = Console.ReadLine();
            stud.yearInSchool = Console.ReadLine();
        }

    }
}

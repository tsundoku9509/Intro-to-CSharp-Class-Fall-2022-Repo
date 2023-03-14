using System;
/**********************
 *Name: Student Structure
 * Author: Austin Mays
 * Created: 10/12/2022
 * Modified: 02/09/2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: Program asks for student's first and last name, student ID, their major, and year of school.
 *
 Output: Program uses the struct Student to proceess and store the user input, then prints each input to console as a list element.
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
           
            while (counter < students)
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
              
                counter++;
            }
         
           Console.WriteLine("Submissions Complete, Thank You!");
           Console.ReadLine();
            
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
            string fName = "First Name";
            string lName = "Last Name";
            string id = "Student ID #";
            string major = "Area of Study";
            string schoolYear = "School Year";
            string enter = "Press Enter for next student.";

            List<string> newStudAcct = new List<string>();
            newStudAcct.Add(fName);
            newStudAcct.Add(first);
            newStudAcct.Add(lName);
            newStudAcct.Add(last);
            newStudAcct.Add(id);
            newStudAcct.Add(stud_id);
            newStudAcct.Add(major);
            newStudAcct.Add(studies);
            newStudAcct.Add(schoolYear);
            newStudAcct.Add(school_year);
            newStudAcct.Add(enter);

            newStudAcct.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}

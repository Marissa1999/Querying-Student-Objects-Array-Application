//ID: 1775227
//Name: Marissa Goncalves
//Assignment 3 - Problem 1: Querying an Array of Student Objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Student
    {

        //Instance variable indicating the student's final grade.
        private int finalGrade;


        //Main constructor that initializes the student's ID, first name, last name and final grade based on the properties.
        public Student(string studentID, string firstName, string lastName, int finalGrade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            FinalGrade = finalGrade;
        }


        //Implicit property for the student's ID.
        public string StudentID
        {
            get; set;
        }


        //Implicit property for the student's first name.
        public string FirstName
        {
            get; set;
        }


        //Implicit property for the student's last name.
        public string LastName
        {
            get; set;
        }


        //Explicit property for the student's final grade.
        public int FinalGrade
        {
            //Gets the student final grade and returns the result.
            get
            {
                return this.finalGrade;
            }

            //Sets the student's final grade and modifies the result in a certain conditon
            set
            {

                //If the method call's value is less than 0, the final grade must be set to 0.
                if (value < 0)
                {
                    this.finalGrade = 0;
                }

                //If the method call's value is more than 100, the final grade must be set to 100.
                else if (value > 100)
                {
                    this.finalGrade = 100;
                }

                //Or else, the final grade is equal to the method call's value.
                else
                {
                    this.finalGrade = value;
                }
            }

        }


        //Prints a student's record table with all attributes displayed with format specifiers.
        public void DisplayStudentRecord()
        {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"|             Student Record             |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| Student ID      | {StudentID, 20} |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| First Name      | {FirstName, -20} |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| Last Name       | {LastName, -20} |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"| Final Grade     | {FinalGrade, 20} |");
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine();
        }
    

    }
}

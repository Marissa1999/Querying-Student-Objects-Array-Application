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
    class StudentTest
    {
        static void Main(string[] args)
        {

            //Create an array of student objects based on the main constructor from the Student class.
            Student[] studentArray = {new Student("1770803", "Jacky", "Huang", 78),
                                      new Student("1744416", "Thuvarragga", "Kandiah", 87),
                                      new Student("1607730", "Jenish", "Kiddinar", 89),
                                      new Student("1554630", "Lukas", "Kires", 96),
                                      new Student("1693681", "Raffaele", "Macera", 75),
                                      new Student("1748388", "Prashanna", "Thanabalasingam", 84),
                                      new Student("1581908", "Krishnna", "Shanmugam", 73),
                                      new Student("1488073", "Mishalini", "Ponniah", 92),
                                      new Student("1566539", "Giuseppe", "Perillo", 74),
                                      new Student("1727547", "Justin", "Medeiros", 68)};


            //Print a title before printing all the student records.
            Console.WriteLine("Student Records:");

            //For every element from the array of students,
            foreach (Student element in studentArray)
            {
                //Call the method to print out the student record displaying the attributes.
                element.DisplayStudentRecord();
            }



            //a) Use LINQ to sort the Student objects by Student ID. 

            //Print a title before printing all the student records sorted by ID.
            Console.WriteLine("Sorted Students by Student ID:");

            //Print the titles for each column in the sorted student ID table.
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"| Student ID     | First Name    | Last Name        | Final Grade  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            //Create a LINQ variable to sort the array of students in ascending order according to ID.
            var sortIDArray =
                from value in studentArray
                orderby value.StudentID
                select value;

            //For every element from the array of students with sorted IDs,
            foreach (Student element in sortIDArray)
            {
                //Print all student attributes in the table, using format specifiers.
                Console.WriteLine($"| {element.StudentID,-14} | {element.FirstName,-13} | {element.LastName,-15}  | {element.FinalGrade,-11}  |");
            }

            //Print the closing dotted line for the sorted student ID table.
            Console.WriteLine($"--------------------------------------------------------------------");

            //Skip a line.
            Console.WriteLine();





            //b) Use LINQ to sort the Student objects by First Name. 

            //Print a title before printing all the student records sorted by first name.
            Console.WriteLine("Sorted Students by First Name:");

            //Print the titles for each column in the sorted student first name table.
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"| Student ID     | First Name    | Last Name        | Final Grade  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            //Create a LINQ variable to sort the array of students in ascending order according to first name.
            var sortFirstNameArray =
               from value in studentArray
               orderby value.FirstName
               select value;

            //For every element from the array of students with sorted first names,
            foreach (Student element in sortFirstNameArray)
            {
                //Print all student attributes in the table, using format specifiers.
                Console.WriteLine($"| {element.StudentID,-14} | {element.FirstName,-13} | {element.LastName,-15}  | {element.FinalGrade,-11}  |");
            }

            //Print the closing dotted line for the sorted student first name table.
            Console.WriteLine($"--------------------------------------------------------------------");

            //Skip a line.
            Console.WriteLine();






            //c) Use LINQ to sort the Student objects by Last Name. 

            //Print a title before printing all the student records sorted by last name.
            Console.WriteLine("Sorted Students by Last Name:");

            //Print the titles for each column in the sorted student first name table.
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"| Student ID     | First Name    | Last Name        | Final Grade  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            //Create a LINQ variable to sort the array of students in ascending order according to last name.
            var sortLastNameArray =
               from value in studentArray
               orderby value.LastName
               select value;

            //For every element from the array of students with sorted last names,
            foreach (Student element in sortLastNameArray)
            {
                //Print all student attributes in the table, using format specifiers.
                Console.WriteLine($"| {element.StudentID,-14} | {element.FirstName,-13} | {element.LastName,-15}  | {element.FinalGrade,-11}  |");
            }

            //Print the closing dotted line for the sorted student last name table.
            Console.WriteLine($"--------------------------------------------------------------------");

            //Skip a line.
            Console.WriteLine();





            //d) Use LINQ to sort the Student objects by Final Grade. 

            //Print a title before printing all the student records sorted by final grade.
            Console.WriteLine("Sorted Students by Final Grade:");

            //Print the titles for each column in the sorted student final grade table.
            Console.WriteLine($"--------------------------------------------------------------------");
            Console.WriteLine($"| Student ID     | First Name    | Last Name        | Final Grade  |");
            Console.WriteLine($"--------------------------------------------------------------------");

            //Create a LINQ variable to sort the array of students in ascending order according to final grade.
            var sortFinalGradeArray =
               from value in studentArray
               orderby value.FinalGrade
               select value;

            //For every element from the array of students with sorted final grades,
            foreach (Student element in sortFinalGradeArray)
            {
                //Print all student attributes in the table, using format specifiers.
                Console.WriteLine($"| {element.StudentID,-14} | {element.FirstName,-13} | {element.LastName,-15}  | {element.FinalGrade,-11}  |");
            }

            //Print the closing dotted line for the sorted student final grade table.
            Console.WriteLine($"--------------------------------------------------------------------");

            //Skip a line.
            Console.WriteLine();





            //e) Use LINQ to select the firstName and finalGrade and sort the results by finalGrade.

            //Print a title before printing all the student records sorted by final grade, displaying only the first name and grade.
            Console.WriteLine("Sorted Students by Final Grade, Selected by First Name and Final Grade");

            //Print the titles for each column in the sorted student final grade table, displaying only the first name and grade.
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"| First Name    | Final Grade   |");
            Console.WriteLine($"---------------------------------");

            //Create a LINQ variable to sort the array of students in ascending order according to final grade and select the first name and final grade attributes.
            var sortSelectionArray =
               from value in studentArray
               orderby value.FinalGrade
               select new { value.FirstName, value.FinalGrade };

            //For every element from the array of students with sorted final grades,
            foreach (var element in sortSelectionArray)
            {
                //Print the first name and final grade student attributes in the table, using format specifiers.
                Console.WriteLine($"| {element.FirstName,-13} | {element.FinalGrade,-13} |");
            }

            //Print the closing dotted line for the sorted student final grade table, only selecting first name and final grade.
            Console.WriteLine($"---------------------------------");

            //Skip a line.
            Console.WriteLine();



        }
    }
}

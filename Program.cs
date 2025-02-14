using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex1
{
    internal class Program
    {
        // list to store grades
        static List<int> grades = new List<int>();

        static void AddGrade()
        {
            //asking user to add a grade between 0 - 100
            Console.WriteLine("Enter a Grade to add (0 - 100): ");
            //checking if user added a grade that is between 0 - 100
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
            {
                //added a valid grade to the list
                grades.Add(grade);
                //message to the user that grad was added
                Console.WriteLine("Grade was successfully added");
            }
            //message to the user that the grade that was submitted was invalid
            else
            { 
                Console.WriteLine("Invalid grade, please add a number between 0 - 100");
            }
        }
        static void removeGrade()
        {
            //checking if there is a grade in the list
            if (grades.Count == 0)
            {
                //telling user that there is no grade to remove
                Console.WriteLine("No grades to Remove");
                //returns to menu if there is no grade
                return;
            }
            //telling user witch grade they want to remove
            Console.WriteLine("Enter a grade to remove");
            //checking if there is a valid number to remove
            if (!int.TryParse.(Console.ReadLine(), out int grade))
            {
                //removes the grade that was inputted
                if (grades.Remove(grade))
                {
                    Console.WriteLine("Grade was Successfully Removed");
                }
                else
                {
                    Console.WriteLine("Grade weas not found");
                }
            }
        }
        static void displayGrades()
        {

        }
        static void calculateAverageGrade()
        {

        }
        static void maxAndMinGrade()
        {

        }
        static void EXIT()
        { 
        
        }
        static void Main(string[] args)
        {
            //menu for Grade Management Application
            //looping through menu so user can keep working on grades

            while (true)
            {
                Console.WriteLine("Welcome to Grade Management Application");
                Console.WriteLine("1 - Add Grade");
                Console.WriteLine("2 - Remove Grade");
                Console.WriteLine("3 - Display Grades");
                Console.WriteLine("4 - Calculate Agerage of grades");
                Console.WriteLine("5 - Find the Highest & Lowest Grade");
                Console.WriteLine("6 - EXIT");

                //user choses witch method they want to chose
                //declaration
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddGrade();
                        break;
                    case "2":
                        removeGrade();
                        break;
                    case "3":
                        displayGrades();
                        break;
                    case "4":
                        calculateAverageGrade();
                        break;
                    case "5":
                        maxAndMinGrade();
                        break;
                    case "6":
                        EXIT();
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }
    }
}

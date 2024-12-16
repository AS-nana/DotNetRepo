using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace VariableWith_Test.HWMethods
{ //Static class attributes that store the person’s details: First name, Last name, Age, Gender.
 //A method that computes the age of the user + X years, where X is parameter
    internal class Persoana
    {

        public static string fname = "Moga";
        public static string lname = "Andrei";
        public static int age = 45;
        public static char gender = 'M';
        
        public static int DisplayAgeAfterX(int x)
        {
            var result = age + x;
            Console.WriteLine($"The user will be {result} after {x} years");
            return result;

        }

        [Test]
        public static void DisplayUserDetails()
        {
            Console.WriteLine("The person's details are as follows: ");
            Console.WriteLine("\t- First Name: " + fname);
            Console.WriteLine("\t- Last Name: " + lname);
            Console.WriteLine("\t- Gender: " + gender);
            DisplayAgeAfterX(12);
            IsOld();
            ShowGender();
        }


        // An “IsOld()” method that uses if-else-if statements:
//If the Person.Age is greater than or equal to 100 then outputs: "You are ancient!“.
//If the Person.Age is greater than or equal to 50 then outputs: "You are old!“.
//If the Person.Age is smaller than 50 then outputs: "You are still young!".
        public static void IsOld()
        {
                if (age >= 100)
                {
                    Console.WriteLine("You are ancient!");
                }
                else if (age >= 50)
                {
                    Console.WriteLine("You are old!");
                }
                else
                {
                    Console.WriteLine("You are still young!");
                }
         }

// A “ShowGender()” method that uses switch statement:
//If Person.Gender is “Male” then outputs: "You are a male!".
//If Person.Gender is “Female” then outputs: "You are a female!".
//Else it outputs: "You haven't specified your gender!"

        public static void ShowGender()
        {
            switch (gender)
            {
                case 'M': // Male
                    Console.WriteLine("You are a male!");
                    break;
                case 'F': // Female
                    Console.WriteLine("You are a female!");
                    break;
                default: // Undefined or other input
                    Console.WriteLine("You haven't specified your gender!");
                    break;
            }
        }
        }
    }


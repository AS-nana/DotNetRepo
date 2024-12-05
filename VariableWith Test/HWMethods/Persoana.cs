using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.HWMethods
{
    internal class Persoana
    {

        public static string fname = "Moga";
        public static string lname = "Andrei";
        public static int age = 50;
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
        }




        }
    }


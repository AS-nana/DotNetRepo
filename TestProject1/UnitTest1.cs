using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*Design a small console app/test that does the following:
        * -accepts user input/test data for "First name", "Last name", "Age" and "Gender"
        * - Computes the age of the user + 20years
        * -Displays back to the console / output the following details: */
        [Test]
        public void Homework3()
        {
            Person person = new()
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 47,
                Gender = "Male"
            };

         Console.WriteLine("Your details are as follows:");
         Console.WriteLine($"\t- First Name: " + person.FirstName);
         Console.WriteLine($"\t- Last Name: " + person.LastName);
         Console.WriteLine($"\t- Gender: " + person.Gender);
         Console.WriteLine($"\t- Age " + person.Age);
         var ageIn20Years = CalculateAgeIn20Years(person.Age);
         Console.WriteLine($"You will be {ageIn20Years} years old in 20 years!");        
        }
        public static int CalculateAgeIn20Years(int currentAge)
        {
            return currentAge + 20;
        }
    }
}
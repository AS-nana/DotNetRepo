using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.HomeworkFirst
{
    public class HW_20years
    {
        string firstName;
        string lastName;
        string gen;
        int age;
        [Test]
        public void metodaTest()
        {
            firstName = "Moga";
            lastName = "Andrei";
            gen = "Male";
            age = 35;
            
            Console.WriteLine("Your details are as follows: ");
            Console.WriteLine("- First Name: " + firstName);
            Console.WriteLine("- Last Name: " + lastName);
            Console.WriteLine("- Gender: " + gen);

            string ageIn20Years;
            ageIn20Years = Convert.ToString(age + 20);

            Console.WriteLine("You will be  " + ageIn20Years + " years old in 20years!");
           
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.Methods
{
    public class MyFirstMethod
    {


        [Test]
        public void MetodaTest()
        {
           // SumNumbers();
           // SumNumbers(60, 45);
           // SumNumbers(60, 45,100);

            int sum = GetResult(15, 20, 66);
            Console.WriteLine("The result is " + sum);
        }

        public void SumNumbers() 
        {
            int number1 = 10;
            int number2 = 700;
            int sum = number1 + number2;
            Console.WriteLine("The result is " + sum);
                    
        }

       public void SumNumbers(int numberA, int numberB)
        {
            int sum = numberA + numberB;
            Console.WriteLine("The result is " + sum);
        }


        public void SumNumbers(int numberA, int numberB, int numberC)
        {
            int sum = numberA + numberB + numberC;
            Console.WriteLine("The result is " + sum);
        }

        public int GetResult(int numberA, int numberB, int numberC) 
        {
            int sum = numberA + numberB + numberC;
            return sum;
        }

    }
}
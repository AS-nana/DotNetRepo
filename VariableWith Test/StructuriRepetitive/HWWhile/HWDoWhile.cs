using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriRepetitive.HWWhile
{
    /*A “CountTo” parameterized method that receives a number and prints to console all the numbers up to that number:
     * Use while or do-while statements to output the numbers to console.\
     * If the currently output number is 10 DO NOT display it, instead output “Number skipped!” message.
     * If the currently output number is 99 then exit the loop and output “Cannot count past 99!”);*/
    public class HWDoWhile
    {
        [TestCase(100)]
        public void CountTo(int numbers)
        {
            int currentNumber = 0;

            while (currentNumber < numbers)
            {
                currentNumber++;
                if (currentNumber == 10)
                {
                    Console.WriteLine($"Number skipped!");
                    continue;
                }
                else if (currentNumber == 99)
                {
                    Console.WriteLine($"Cannot count past 99");
                    break;
                }
                else
                {
                    Console.Write($"{currentNumber};");
                }
            }
            // another example with do while
            //do
            //{
            //    currentNumber++;
            //    if (currentNumber == 12)
            //    {
            //        Console.WriteLine("Number skipped!");
            //        continue;
            //    }
            //    else if (currentNumber == 50)
            //    {
            //        Console.WriteLine($"Cannot count past 50");
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write($"{currentNumber};");
            //    }
            //}
            //while (currentNumber < numbers);
        }
    }
}
   

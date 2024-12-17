using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.StructuriAlternative.tema
{
    public class ParPozitivNegativ
    {
        [Test]
        public void CheckNumberIfPositiveOrNegative()
        {
            //Console.WriteLine("Introduceti un numar: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            int number = 0;

            if (number % 2 == 0)
            {
                if (number > 0)
                {
                    Console.WriteLine("Numarul este par pozitiv");
                }
                else if (number < 0) 
                {
                    Console.WriteLine("Numarul este par negativ");
                }
                else
                {
                    Console.WriteLine("Numarul este zero si este par");
                }
            }
            else
            {
                Console.WriteLine("Numarul este impar");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.StructuriAlternative
{
    public class Exercitii
    {
        [Test]
        public void TestMethod()
        {
            //VerificareNumar(22, 13);
            CompareDigits(15);
            Verificaremasina("Toyota");
        }

        public void VerificareNumar(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat numarul  {y}");
            }
            else {
                Console.WriteLine($"Numarul {x} este mai mic decat numarul  {y}");
            }
        }

        public void CompareDigits(int x)
        {
            if (x < 5)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat 5");
            }
            else if (x > 5)
            {
                Console.WriteLine($"Numarul {x} este mai mare decat 5");
            }
            else
            {
                Console.WriteLine($"Numarul {x} este egal cu 5");
            };
        }


        public void Verificaremasina(string masina)
        {
            switch (masina)
            {
                case "Toyota":
                    Console.WriteLine("Este disponibil Toyota");
                    break;
                case "Suzuki":
                    Console.WriteLine("Este disponibil Suzuki");
                    break;
                case "BMW":
                    Console.WriteLine("Este disponibil BMW");
                    break;
                default:
                    Console.WriteLine("Marca nu este disponibila");
                    break;

            }

        }

     } }

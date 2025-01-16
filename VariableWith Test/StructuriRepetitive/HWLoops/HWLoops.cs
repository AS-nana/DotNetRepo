using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using System.Xml.Linq;
using VariableWith_Test.HWMethods;
using System.Security.Cryptography.X509Certificates;

namespace VariableWith_Test.StructuriRepetitive.HWLoops
{
    /*In the “Person” class add the following:A class attribute “List<string> Skills“ – to store the list of skills for the person.
     A parameterized method to add a skill to the person.
    This method also outputs to the console the name of the newly added skill.
A method to output to console all the skills of the person:
Use either for or foreach statements to output the list to console.
    If the currently output skill is “Ninja” DO NOT display it.
If the currently output skill is “CIA” then exit the loop and output “Classified information, no further skills are displayed!”.*/
    public class HWLoops
    {
        private List<string> Skills = new List<string>

            {
              "Cooking", "Photography","Programming","Testing","Ninja","Swimming","CIA","Dancing","Singing"
            };
        [Test]
        public void PersonSkills()

        {
            foreach (string skill in Skills)
            {
                Console.WriteLine($"Added a new skill: " + skill);
            }

            Console.WriteLine("The person has the following skills:");
            foreach (var skill in Skills)
            {
                if (skill == "Ninja")
                {
                    // Skip the skill "Ninja"
                    continue;
                }

                if (skill == "CIA")
                {
                    // Exit the loop when skill is "CIA" and display a message
                    Console.WriteLine(">>>>>>Classified information, no further skills are displayed!<<<<<");
                    break;
                }

                // Output the skill

                Console.WriteLine($"- {skill}");
            }
            /*
                        [Test]
                        public void DisplaySkillsWithConditions()
                        {
                            Console.WriteLine("The person has the following skills:");
                            foreach (var skill in Skills)
                            {
                                if (skill == "Ninja")
                                {
                                    // Skip the skill "Ninja"
                                    continue;
                                }

                                if (skill == "CIA")
                                {
                                    // Exit the loop when skill is "CIA" and display a message
                                    Console.WriteLine(">>>>>>Classified information, no further skills are displayed!<<<<<");
                                    break;
                                }

                                // Output the skill

                                Console.WriteLine($"- {skill}");
                            }
                        }*/


        }
    }
}

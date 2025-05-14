using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP.Inheritance
{
    public class Test
    {
        //mostenire= concept prin care o clasa copil mosteneste alta clasa parinte
        //in C# se poate mosteni doar o singura clasa
        // clasa copil preia proprietatile si metodele unei clase parinte
        [Test]
        public void TestMethod()
        {
            //var person = new Person("Mihai", 30, 69.5);
            //person.InfoPerson();

            var ion = new Angajat("Ion", 36, 85.4, "inginer", 3540, "MitInstal");
            ion.InfoAngajat();

            var stud = new Student("IMaria", 22, 48.9, "USAMV", "horticultura", true);
                stud.InfoStudent();
        }
    }
}

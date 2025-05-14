using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP
{
    public class Car_tests
    {
        [Test]

        public void CarTests()
        {
            Cars car1 = new Cars("diesel","red", 5, 1.9);
            car1.DisplayData();
            Console.WriteLine();
            Cars car2 = new Cars("benzina", "purple", 2, 2.0);
            car2.DisplayData();
            Console.WriteLine();
            Cars car3 = new Cars("benzina", "blue", 2, 2.0, "automate");
            car3.DisplayData();

            var car4 = new Cars("electrical", "green", 5, 2.0, "automate");
           car4.DisplayData();
        }

    }
}

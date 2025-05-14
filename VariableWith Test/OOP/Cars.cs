using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP
{
    public class Cars
    {
        string engine;
        string culoare;
        int doors;
        double cilinders;
        string gearboxType;

        public Cars(string engine, string culoare, int doors, double cilinders) 
        {
            this.engine = engine;
            this.culoare = culoare;
            this.doors = doors;
            this.cilinders = cilinders;                        
        
        }
        public Cars( string engine, string culoare, int doors, double cilinders, string gearboxType)
        {
            this.engine = engine;
            this.culoare = culoare;
            this.doors = doors;
            this.cilinders = cilinders;
            this.gearboxType = gearboxType;

        }


        public void DisplayData()
        {
            Console.WriteLine($"Engine is: {engine}");
            Console.WriteLine($"The color is: {culoare}");
            Console.WriteLine($"No of doors is: {doors}");
            Console.WriteLine($"Cilinders is: {cilinders}");

            if(gearboxType != null)
                Console.WriteLine($"Gearbox type is: {gearboxType}");
        }

    }
}

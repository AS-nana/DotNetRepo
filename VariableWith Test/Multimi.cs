using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListArrayDictionaries
{
    public class Multimi
    {
        [Test]
        public void Test1()
        {
            Dictionary<string, string> obiecte = new Dictionary<string, string>
            {
                {"obiect", "laptop"},
                {"fruct", "para"},
                {"sport", "inot"},
            };
            //foreach (var obj in obiecte)
            //{
            //    Console.WriteLine($"The key is {obj.Key}");
            //    Console.WriteLine($"The value is {obj.Value}");
            //}


            Dictionary<string, List<string>> clasificare = new Dictionary<string, List<string>>();
            List<string> oraseRomania = new List<string> { "Bucuresti","Cluj-Napoca", "Timisoara"};
            List<string> oraseGermania = new List<string> { "Berlin","Hamburg", "Munchen"};
            List<string> oraseFranta = new List<string> { "Paris","Loire", "Lyon"};

            clasificare.Add("Romania", oraseRomania);
            clasificare["Romania"] = oraseRomania;
            clasificare["Franta"] = oraseFranta;
            clasificare["Germania"] = oraseGermania;

            //foreach (var key in clasificare)
            //{
            //    foreach(var value in key.Value)
            //    {
            //        Console.WriteLine($"The country is {key.Key}");
            //        Console.WriteLine($"The city is {value}");
            //    }
            //}

            foreach (var key in clasificare.Keys)
            {
                Console.WriteLine($"Tara este: {key}");
                Console.WriteLine($"Orasele sunt:" + string.Join(",", clasificare[key]));

            }


        }

    }
}


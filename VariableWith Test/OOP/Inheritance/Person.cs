using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP.Inheritance

{
    public class Person
    {
        public string name;
        public int age;
        public double weight;

        public Person(string name, int age, double weight)
        { 
        this.name = name;
        this.age = age;
        this.weight = weight;
        }

        public void InfoPerson()
        {
            Console.WriteLine($"Nume persoana este: {name}");
            Console.WriteLine($"Varsta pesoana: {age}");
            Console.WriteLine($"Greutate persoana: {weight}");
        }

    }
}

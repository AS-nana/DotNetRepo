using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP.Inheritance
{
    public class Student : Person

{
    public string university;
    public string profil;
    public bool bursa;

    public Student(string name, int age, double weight, string university, string profil, bool bursa) : base(name, age, weight)
    {
        this.university = university;
        this.profil = profil;
        this.bursa = bursa;
    }

    public void InfoStudent()
    {
        InfoPerson();
        Console.WriteLine($"Student la: {university}");
        Console.WriteLine($"Student la profil: {profil}");
        Console.WriteLine($"Are bursa: {bursa}");

    }
}
}


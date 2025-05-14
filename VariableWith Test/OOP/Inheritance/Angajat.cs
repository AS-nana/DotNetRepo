using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.OOP.Inheritance

{

    public class Angajat : Person

{
	public string job;
	public double salary;
	public string employer;

	public Angajat(string name, int age, double weight, string job, double salary, string employer) : base(name, age, weight)
	{
		this.job = job;
		this.salary = salary;
		this.employer = employer;
	}

	public void InfoAngajat()
	{
		InfoPerson();
		Console.WriteLine($"Job angajat: {job}");
		Console.WriteLine($"Salariu angajat: {salary}");
		Console.WriteLine($"Angajator: {employer}");

	} }
}
	

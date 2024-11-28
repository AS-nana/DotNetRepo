namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Homework3()
        {       
         Console.WriteLine("Insert your First name: ");
         string firstName = Console.ReadLine();
         Console.WriteLine("Insert your Last name: ");
         string lastName = Console.ReadLine();
         Console.WriteLine("Insert your age: ");
         Int32 age = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Insert your gender: ");
         string gender = Console.ReadLine();

         int ageIn20Years = age + 20;

         Console.WriteLine("Your details are as follows:");
         Console.WriteLine($"\t- First Name: {firstName}");
         Console.WriteLine($"\t- Last Name: {lastName}");
         Console.WriteLine($"\t- Gender: {gender}");
         Console.WriteLine($"You will be {ageIn20Years} years old in 20 years!");

         Console.ReadKey();

        }
    }
}
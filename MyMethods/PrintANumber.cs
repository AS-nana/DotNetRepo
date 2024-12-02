namespace MyMethods
{
    public class Program
    {
        [SetUp]
        public void Setup()
        {
            PrintNumber();
            PrintNumber();
        }

        [Test]
        public void PrintNumber()
        {
            Random numGen = new Random();
            int number = numGen.Next(0, 10);
            Console.WriteLine(number);
        }
    }
}
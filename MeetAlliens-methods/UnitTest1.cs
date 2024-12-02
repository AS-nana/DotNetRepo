namespace MeetAlliens_methods
{
    public class Alien
    {
        public void Main()
        {
            MeetAlien();
            Console.WriteLine("-----");
            MeetAlien();

            int result = Square(5);
            //Wait before closing
            Console.ReadKey();
        }

        [Test]
        public void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X- " + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("Oh, and I'm a cute alien" );
        }

        int Square(int number)
        {
            int result = number * number;
            return result;
        }
    }
}
namespace Loops
{
    public class StructuriRepetitive
    {
        [Test]
        public void forLoop()
        {
            //for (int i= 1; i<=7; i++) ;
            //{
            //    Console.WriteLine(i);
            //}

            /*int i = 1;

            for (; i <= 8; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 0;
            for (; i <= 10;)
            {
                Console.WriteLine(i);
                i++;
            }*/

            //definim un array
            string[] numeColegi = new string[3];
            numeColegi[0] = "Ana";
            numeColegi[1] = "Maria";
            numeColegi[2] = "Silviu";

            for (int i = 0; i < numeColegi.Length; i++)
            {
                Console.WriteLine(numeColegi[i]);
            }

            //definim o lista
            List<string> listaColegi = new List<string>
            {
              "Andrei", "Bogdan","Cristi"
            };

            foreach (string numeColeg in listaColegi)
            {
                Console.WriteLine(numeColeg);
            }
        }

        [Test]
        public void WhileLoop()
        {
            //int counter = 18;
            //while (counter <= 36)
            //{
            //    Console.WriteLine($"The current counter value is: {counter}");
            //    counter++;
            //}
           // MethodWhile(-14, -2);
           // WhileBreak(2, 10, 5);
            //WhileContinous(2, 10, 5);
            DoWhileMethod();
        }

        public void MethodWhile(int counter, int limit)
        { 
            while (counter <= limit) 
            {
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
            }        
        }

        public void WhileBreak(int counter, int limit, int stopValue) 
        {
            while (counter <= limit)
            {
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
                if (counter == stopValue)
                {
                    break;
                }
            }
        }


        public void WhileContinous(int counter, int limit, int skipValue)
        {
            while (counter <= limit)
            {
                counter++;
                if (counter == skipValue)
                {
                    continue;
                }
                Console.WriteLine($"The current counter value is: {counter}");                
            }
        }


        public void DoWhileMethod()
        {
            int counter = -5;
            do
            {
                Console.WriteLine($"The value is: {counter}");
                counter++;

            }
            while (counter <= 5);
        }

    }
}
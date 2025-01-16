namespace Loops
{
    public class StructuriRepetitive
    {
        [Test]
        public void Test1()
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
    }
}
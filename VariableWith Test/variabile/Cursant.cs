using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableWith_Test.variabile
{
    public class Cursant
    {
        //declarare variabilelor
        string numeCursant;
        string prenumeCursant;
        int varsta;
        int cnp;
        bool esteactiv;
        char gen;
        float nota;
        double inaltime;


        [Test]
        public void metodaTest ()
        {
            //initializarea variabilelor, dam valori
            numeCursant = "Moga";
            prenumeCursant = "Andrei";
            varsta = 22;
            //cnp = 10840569212151;
            var numarLung = 16840654545515;
            esteactiv = true;
            gen = 'M';
            nota = 8.2f;
            inaltime = 1.85;


            Console.WriteLine("Nume si prenume cursant: " + numeCursant +" " + prenumeCursant);
            Console.WriteLine("Varsta cursant: " + varsta);
            Console.WriteLine("Nota: " + nota);

          
        }

    }
}

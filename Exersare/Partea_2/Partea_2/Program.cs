using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partea_2
{
    public class persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumeComplet()
        {
            return Nume + " " + Prenume;
        }
        public string NumeleComplet // Proprietate care imita metoda
        {
            get
            {
                return Nume + " "+ Prenume;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Lucru cu Math
            double x = 50.5;
            double y = 125;
            Console.WriteLine(Math.Round(x, 0, MidpointRounding.AwayFromZero)); // rotunjeste la 51
            Console.WriteLine(Math.Round(x)); // Rotunjeste la 50
            Console.WriteLine(Math.Min(x, y)); // Maximul
            Console.WriteLine(Math.Max(x, y)); // Minimul
            Console.WriteLine(Math.Abs(x)); // Echivalentul cu modulul numarului
            Console.WriteLine(Math.Sign(x)); // Returneaza o valoare echivalenta cu semnul numarului
            Console.WriteLine();

            // Lucru cu tipul de date char
            char litera = 'a';
            int numar = 'a';
            Console.WriteLine($""+litera +" "+ numar+"\n");
            char litera1 = (char)142; // Conversie cu tipul cast
            Console.WriteLine(litera1+"\n");

            //Lucru cu stringuri
            string sir1 = "Csharp";
            string sir2 = sir1;
            sir1 += " e super misto :)";
            Console.WriteLine(sir1 + "\n" + sir2+"\n"); // Cum functioneaza referintele la stringuri
            char[] caractere = { 's', 'a', 'l', 'u', 't' };
            string salutare = new string(caractere); // Conversia la string utilizand constructorul
            Console.WriteLine(salutare);
            string nume = "Matei";
            string salutari = $"Salut numele meu este {nume}, si vreau sa spun {salutare}"; // Interpolarea Stringurilor
            Console.WriteLine(salutari);
            Console.WriteLine($"\a{nume}");
            Console.WriteLine($"Numele meu este \"{nume}\""); // Folosirea Citatului
            string as_is = @"Dupa cum se stie \t exista [..]"; // Ignora secventele de iesire
            Console.WriteLine(as_is);

            //Lucru cu clase, metode si proprietati
            persoana p1 = new persoana();
            p1.Nume = "Ion"; // Folosirea proprietatilor
            p1.Prenume = "Barbu";
            Console.WriteLine(p1.NumeComplet()); // apelarea metodei cu tipul Return
            Console.WriteLine($"{p1.Nume} {p1.Prenume}\n"); // Afisarea datelor din proprietati
            Console.WriteLine(p1.NumeleComplet); // apelarea proprietatii

            // Lucru cu else if
            int a=101;
            Console.WriteLine("Dati valoarea lui b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == a)
                Console.WriteLine("Corect");
            else if (b != a)
                Console.WriteLine("gresit");
            int c=Int32.Parse(Console.ReadLine()); // Arunca o exceptie daca nu poate face conversia. Folosim daca stim ca valoarea e valida
            Int32.TryParse(Console.ReadLine(), out c); // Returneaza un bool pentru a arata daca a reusit conversia sau nu
            Console.WriteLine(c);

            // Lucru cu switch
            string key=Console.ReadLine();
            switch(key)
            {
                case "Matei":
                case "Tiberiu":
                    Console.WriteLine($"Ce mai faci {key}"); // Valabil pentru numele din case-uri
                    break;
                default:
                    Console.WriteLine("Nume inexistent");
                    break;
            }

            //Lucru cu operatorul ternar (inlocuieste if/else)
            bool corect = true;
            int puncte = corect ? 10 : 0; // verifica daca corect e true
            Console.WriteLine(puncte);

            //Lucru cu Arrays
            int[] numere = { 23, 421, 92, 1, 324 };
            int[] numere1 = { 23, 421, 92, 1, 324 };
            Array.Sort(numere);
            Array.Reverse(numere);
            for(int i=0;i<numere.Length; i++)
            {
                Console.WriteLine(numere[i]);
            }
            Console.WriteLine(Array.IndexOf(numere, 1));
            Console.WriteLine();
            if (Enumerable.SequenceEqual(numere, numere1))
                Console.WriteLine("Sunt egale");
            else
                Console.WriteLine("Nu sunt egale");

        }
    }
}

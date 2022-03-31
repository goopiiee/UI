using System;
// laborator 4 >> siruri de caractere si linie de comanda
namespace laborator_4
{
    class program
    {
        static void Main(string[] args) // > Lucru cu tablouri de mai multe dimensiuni
        {
            // Tablouri in scara cu initializare prin new si tip
            int[,] numere = new int[3, 2] { { 1, 2 }, { 6, 3 }, { 3, 4 } }; // grupuri, numarul de elemente din fiecare grup
            string[,] nume = new string[2, 2] { { "Ion", "Barbu" }, { "Marian", "Andrei" } };
            System.Console.WriteLine(numere[1, 0]); // Afiseaza numarul din grupul 1,pe pozitia 0 (6 din {6,3})
            System.Console.WriteLine(numere[0, 1]); // Afiseaza 2
            System.Console.WriteLine(nume[1, 1]); // Afiseaza Andrei
                                                  // Tablouri in scara fara initializare prin new si/sau tip
            int[,] numere_1 = new int[,] { { 12, 24 }, { 45, 59 }, { 102, 203 } };
            string[,] nume_1 = new string[,] { { "Ion", "Barbu", "Marian" }, { "Andrei", "Marian", "Stefan" } };
            string[,] prenume = { { "Marian", "Barbu", "Ionel" }, { "Leonard", "Tiberiu", "Razvan" } };
            System.Console.WriteLine(numere_1[1, 1]);
            System.Console.WriteLine(nume_1[0, 1]);
            System.Console.WriteLine(prenume[1, 1]);
            //Tablou tridimensional
            int[,,] array = new int[1, 2, 3];
            array[0, 0, 0] = 345;
            array[0, 0, 1] = 456;
            array[0, 0, 2] = 789;
            System.Console.WriteLine(array[0, 0, 0]);
            System.Console.WriteLine(array.Length); // lungimea tabloului
            System.Console.WriteLine("Elementele array-ului sunt {2} | {1} | {0}", array[0, 0, 0], array[0, 0, 1], array[0, 0, 2]);
            // Tablouri in scara cu elemente tot tablouri
            int[][] numere_2 = new int[][] { new int[] { 1, 3, 4 }, new int[] { 2, 3, 4, 5, 6 } };
            System.Console.WriteLine(numere_2[0][1]); // Afiseaza 3 din primul vector
                                                      // Tablouri in scara ce contin tablouri cu numar diferit de elemente
            int[][] tablou = new int[3][];
            tablou[0] = new int[2];
            tablou[1] = new int[6];
            tablou[2] = new int[1];
            int i, j;
            // Citim elementele din tablou
            System.Console.WriteLine("Introduceti elemente tabloului in scara");
            for (i = 0; i < tablou.Length; i++)
                for (j = 0; j < tablou[i].Length; j++)
                {
                    Console.Write("Tablou[{0}][{1}] = ", i, j);
                    tablou[i][j] = Int32.Parse(Console.ReadLine()); // convertirea la int32 a unei valori citite de la tastatura
                }
            // Afisam elementele din tablou
            for (i = 0; i < tablou.Length; i++)
            {
                for (j = 0; j < tablou[i].Length; j++)
                    System.Console.Write("{0} ", tablou[i][j]);
                System.Console.WriteLine();
            }
        }
    }
}
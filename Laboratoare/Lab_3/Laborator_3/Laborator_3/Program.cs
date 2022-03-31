using System;
namespace lab3_p1
{
    class program
    {
        static void Main(string[] args)
        {
            // Vector de intregi
            int[] vector;
            vector = new int[3]; // alocarea de memorie
            int[] vector_int = { 1, 2, 3, 4, 5 }; // vector de intregi fara specificarea explicita a dimensiunii
            int lungimeVect = vector.Length; // Lungimea vectorului
            float[] float_vector = new float[4];
            float_vector[0] = 2;
            float_vector[1] = 3.14f;
            float_vector[2] = (float)2.718;
            float_vector[3] = 45;
            for (int i = 0; i < float_vector.Length; i++)
                Console.WriteLine(float_vector[i]);
            Console.WriteLine();

            // Vector de siruri de caractere
            string[] vect_string;
            vect_string = new string[200]; // alocarea de memorie cu maxim 100 elemente
            string[] elevi = { "Ion", "Andrei", "Stefan" };
            foreach (string element in elevi) // utilizarea foreach pentru accesarea elementelor dintr-un vector
                Console.WriteLine(element);
            Console.WriteLine();

            // Siruri de caractere
            string propozitie = "Program cu stringuri";
            string[] cuvinte = propozitie.Split(' '); // utilizarea Split/Strtok in C++
            foreach (string element in cuvinte)
                Console.WriteLine("{0}", element);
            Console.WriteLine();

            // Utilizare metoda join
            string prop_modificata = string.Join("_", cuvinte);
            Console.WriteLine("Propozitia modifica este : {0}", prop_modificata);
        }
    }
}
using System;
namespace aplicatie
{
    class program
    {
        static void Main(string[] args)
        {
            program obiect=new program(); // > exemplu pentru metode instantiate cu ajutorul obiectelor dintr-o clasa
            obiect.print();
            Console.WriteLine(args[0]); // > permite introducerea de date din cadrul executiei | exemplu "dotnet run salut csharp"
            var x = Console.ReadLine(); // > putem folosi in cazul in care nu suntem siguri de tipul de data al variabilei, de preferabil nu
            Console.WriteLine($"Continutul din varibila x este {x}"); // > exemplu de string interpolation
            int[] x = {1,2,3}; // > exemplu de utilizare al referintelor
            int[] b = x;
            Console.WriteLine(x[0]);
            Console.WriteLine(b[0]);
            b[1]=10;
            Console.WriteLine(x[1]);
            Console.WriteLine(b[1]);
            //> ↓ sau printr-o metoda ↓
            metoda(x);
            Console.WriteLine("{0},{1},{2}",x[0],x[1],x[2]);
            //> ↓ lucru cu tipurile double si decimal ↓
            double x = double.Epsilon;
            Console.WriteLine(x);
            double y = double.NaN;
            Console.WriteLine(double.IsNaN(y));
            double z = Math.Pow(1234,12345);
            Console.WriteLine(double.IsInfinity(z));
            Console.WriteLine(double.IsNegativeInfinity(z));
            decimal var1=10M;
            decimal var2=23M;
            Console.WriteLine(decimal.Compare(var1,var2));
            Console.WriteLine(decimal.Add(var1,var2));
        }
        void print() //  > metoda instantiata
        {
            Console.WriteLine("Salutare :)");
            Console.WriteLine("Csharp partea 1");
            Console.ReadKey();
        }
        static void metoda(int[] b) // > referinta utilizata intr-o metoda
        {
            b[0]=59;
            b[1]=68;
            b[2]=45;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace aplicatie
{
    class program
    {
    class dreptunghi
    {
        public int lungime,latime;
        public int perimetru(){return 2*lungime+2*latime;}
        public void afisare(){Console.WriteLine(lungime + " " + latime);}
        public dreptunghi(int Lungime,int Latime)
        {
            lungime=Lungime;
            latime=Latime;
        }
        
    }
    static void Main(string[] args)
    {
        dreptunghi d=new dreptunghi(4,5);
        d.afisare();
        Console.WriteLine(d.perimetru());
    }
    }
}
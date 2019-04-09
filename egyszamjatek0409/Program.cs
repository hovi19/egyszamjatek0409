using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyszamjatek0409
{
    class jatekos
    {
        public string nev;
        public int tip1;
        public int tip2;
        public int tip3;
        public int tip4;

        public jatekos(string sor)
        {
            string[] adatok = sor.Split(' ');
            this.nev = adatok[0];
            this.tip1 = int.Parse(adatok[1]);
            this.tip2 = int.Parse(adatok[2]);
            this.tip3 = int.Parse(adatok[3]);
            this.tip4 = int.Parse(adatok[4]);
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
        }
    }
}

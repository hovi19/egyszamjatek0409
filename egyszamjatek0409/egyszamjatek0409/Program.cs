using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace egyszamjatek0409
{
    class Jatekos
    {
        public string nev;
        public int[] tippek;

        public Jatekos(string sor)
        {
            var t = sor.Split(' ');
            this.nev = t[0];
            this.tippek = new int[t.Length - 1];

            for (int i = 0; i < this.tippek.Length; i++)
            {
                tippek[i] = int.Parse(t[i + 1]);
            }
        }
    }
    class Program
    {
        static List<Jatekos> jatekosok;
        static int fsorszam;

        static void Main(string[] args)
        {
            Feladat02();
            Feladat03();
            Feladat04();
            Feladat05();

            Console.ReadKey();
        }

        private static void Feladat05()
        {
            Console.Write("5.feladat");
            int sum = 0;
            foreach (var j in jatekosok)
            {
                sum += j.tippek[fsorszam - 1];
            }
            Console.Write("A megadott forduló tippjeinek átlaga: {0:0.00}",(float)sum/jatekosok.Count);
        }

        private static void Feladat04()
        {
            Console.Write("\n4.feladat: ");
            Console.Write("Kérem a forduló sorszámát:");
            fsorszam = int.Parse(Console.ReadLine());
        }

        private static void Feladat03()
        {
            Console.Write("3.feladat: ");
            Console.Write($"Résztvevők száma: {jatekosok.Count}fő");
        }

        private static void Feladat02()
        {
            jatekosok = new List<Jatekos>();
            var sr = new StreamReader("egyszamjatek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}

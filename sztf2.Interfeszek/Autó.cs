using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Interfeszek
{
    public class Autó : IEladható, IKolcsonozheto, IComparable
    {
        private static Random r = new Random();
        private int ar;
        public int Ar { get { return ar; } }
        public string Rendszam{ get; }
        public string Marka { get; }
        public int Hengerurtartalom { get; }

        public Autó(string rendszam, string marka, int hengerurtartalom)
        {
            this.Rendszam = rendszam;
            this.Marka = marka;
            this.Hengerurtartalom = hengerurtartalom;
            ar = Hengerurtartalom * marka.Length;
        }

        public int KolcsonzesiAr()
        {
            return ar / 5;
        }

        public void LeAkcioz()
        {
            ar -= r.Next(0, ar);
        }

        public int CompareTo(object? obj)
        {
            Autó a = this;
            Autó b = obj as Autó;

            return a.Ar.CompareTo(b.Ar);
        }
    }
}

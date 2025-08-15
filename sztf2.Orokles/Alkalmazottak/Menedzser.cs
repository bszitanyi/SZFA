using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Orokles.Alkalmazottak
{
    public class Menedzser : Alkalmazott
    {
        public int BeosztottakSzama { get; set; }
        public bool IsFaszfej { get; set; }

        public Menedzser(string nev, int ev, int alapfizetes, int BeosztottakSzama, bool IsFaszfej) : base(nev, ev, alapfizetes)
        {
            this.BeosztottakSzama = BeosztottakSzama;
            this.IsFaszfej = IsFaszfej;
        }

        public override int Jutalek
        {
            get 
            {
                return ((int)(DateTime.Now - Belepes).TotalDays / 365) * BeosztottakSzama * 5000;
            }
        }

        public override string ToString()
        {
            return "Én egy menedzser vagyok, a nevem: " + this.Nev + $"és a jutalékom: {Jutalek}";
        }
    }
}

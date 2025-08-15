using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Orokles.Alkalmazottak
{
    public class Uzletkoto : Alkalmazott
    {
        public int UzletekSzama { get; set; }
        public override int Jutalek
        {
            get
            {
                return UzletekSzama * 10000;
            }
        }

        public Uzletkoto(string nev, int ev, int alapfizetes, int uzletek)
            : base(nev, ev, alapfizetes)
        {
            this.UzletekSzama = uzletek;
        }

        public override string ToString()
        {
            return "Én egy üzletkötő vagyok, a nevem: " + this.Nev + $"és a jutalékom: {Jutalek}";
        }
    }
}

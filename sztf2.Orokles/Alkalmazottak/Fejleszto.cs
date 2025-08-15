using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Orokles.Alkalmazottak
{
    public class Fejleszto : Alkalmazott
    {
        public Fejleszto(string nev, int ev, int alapfizetes, int gitRepok, double AtalgosKod) : base(nev, ev, alapfizetes)
        {
            this.GitRepokSzama = gitRepok;
            this.AtlagosKodsorProjektenkent = AtalgosKod;
        }

        public int GitRepokSzama { get; set; }
        public double AtlagosKodsorProjektenkent { get; set; }

        public override int Jutalek
        {
            get 
            {
                return (int)(GitRepokSzama * AtlagosKodsorProjektenkent) / (Belepes.Year - 2000);
            }
        }

        public override string ToString()
        {
            return $"Im a Developer, my name is {Nev} and my salary is {Jutalek}";
        }
    }
}

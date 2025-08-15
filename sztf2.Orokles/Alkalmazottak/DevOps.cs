using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Orokles.Alkalmazottak
{
    public class DevOps : Fejleszto
    {
        public DevOps(string nev, int ev, int alapfizetes, int gitRepok, double AtalgosKod) : base(nev, ev, alapfizetes, gitRepok, AtalgosKod)
        {
        }

        public void Uzemeltet()
        {
            Console.WriteLine("Szerintem ez a szerver nem működik...");
        }
    }
}

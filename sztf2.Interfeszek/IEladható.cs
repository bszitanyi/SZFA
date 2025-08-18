using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sztf2.Interfeszek
{
    public interface IEladható
    {
        int Ar { get; }

        void LeAkcioz();
    }

    public interface IKolcsonozheto
    {
        int KolcsonzesiAr();
    }
}

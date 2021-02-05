using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarat
{
    class NegativKesesExeption : Exception
    {
        public NegativKesesExeption(string jaratSzam, int keses)
            : base("A " + jaratSzam + " számú járat negatívan késne " + keses + "perccel")
        {
        }
    }
}

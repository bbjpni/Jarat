using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarat
{
    public class Jarat
    {
        public string JaratSzam;
        public string HonnanRepter;
        public string HovaRepter;
        public DateTime Indulas;
        public int Keses;

        public Jarat(string jaratSzam, string honnanRepter, string hovaRepter, DateTime indulas, int keses)
        {
            JaratSzam = jaratSzam;
            HonnanRepter = honnanRepter;
            HovaRepter = hovaRepter;
            Indulas = indulas;
            Keses = keses;
        }
    }

    public class JaratKezelo
    {
        public List<Jarat> lista;

        public JaratKezelo()
        {
            this.lista = new List<Jarat>();
        }
        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            Jarat j = new Jarat(jaratSzam, repterHonnan, repterHova, indulas, 0);
            lista.Add(j);
        }

        public void Keses(string jaratSzam, int keses)
        {
            bool talalat = false;
            for (int i = 0; i < lista.Count && !false; i++)
            {
                int szum = lista[i].Keses + keses;
                talalat = lista[i].JaratSzam == jaratSzam;
                if (talalat && szum < 0)
                {
                    throw new NegativKesesExeption(jaratSzam, keses);
                }
                else
                {
                    lista[i].Keses += keses;
                }
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            DateTime back = new DateTime();
            bool talalat = false;
            for (int i = 0; i < lista.Count && !false; i++)
            {
                talalat = lista[i].JaratSzam == jaratSzam;
                if (talalat)
                {
                    back = lista[i].Indulas.AddMinutes(lista[i].Keses);
                }
            }
            return back;
        }

        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> back = new List<string>();
            foreach (Jarat j in lista)
            {
                if (j.HonnanRepter.Equals(repter))
                {
                    back.Add(j.JaratSzam);
                }
            }
            return back;
        }
    }
}

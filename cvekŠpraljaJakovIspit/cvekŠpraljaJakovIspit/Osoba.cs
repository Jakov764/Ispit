using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovIspit
{
    public class Osoba
    {
        string ime;
        string prezime;
        string oib;
        string godina;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Oib { get => oib; set => oib = value; }
        public string Godina { get => godina; set => godina = value; }

        public Osoba(string Ime, string Prezime, string Oib, string Godina)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Oib = oib;
            this.Godina = godina;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + oib + " "  + godina + "\n";
        }

    }
}

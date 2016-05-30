using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola
{
    public enum Kategorija { A, B, C, C1, C1E, CE, D };
    public class Komisija : Osoba
    {
        public int Rejting { get; set; }
        public List<Kategorija> Kategorije { get; set; }

        public Komisija (string _ime, string _prezime, DateTime _datumRod, Spol _spol, string _email, string _telefon, int _rejting, List<Kategorija> _kategorije ) : base(_ime,_prezime, _datumRod, _spol,_email,_telefon)
        {
            Kategorije = new List<Kategorija>();
            Rejting = _rejting;
            Kategorije = _kategorije;
        }

    }
}

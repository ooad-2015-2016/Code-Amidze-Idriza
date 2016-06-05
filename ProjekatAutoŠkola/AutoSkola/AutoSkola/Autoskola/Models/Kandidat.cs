using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Autoskola.Models
{
    public class Kandidat : Osoba
    {
        public string mjestoStanovanja { get; set; }
        public bool vozackiIspit { get; set; }
        public bool prvaPomoc { get; set; }
        public bool teoretskiDio { get; set; }
        public List<Kategorija> polozeneKategorije { get; set; }
        public Kandidat(string _ime, string _prezime, DateTime _datumRod, Spol _spol, string _email, string _telefon, string _pass,
                         string _mjestoStanovanja)
            : base(_ime, _prezime, _datumRod, _spol, _email, _telefon, _pass)
        {
            mjestoStanovanja = _mjestoStanovanja;
            vozackiIspit = false;
            prvaPomoc = false;
            teoretskiDio = false;
            polozeneKategorije = new List<Kategorija>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola.Autoskola.Models
{
    
    public class Instruktor : Osoba
    {
        public List<Kategorija> KategorijePoducavanja { get; set; }
        public int Rejting { get; set; }
        public int BrojPoducenihKandidata { get; set; }
        public string BrojInstruktorskeDozvole { get; set; }

        public Instruktor(string _ime, string _prezime, DateTime _datumRod, Spol _spol, string _email, string _telefon, string _pass,
                            List<Kategorija> _katPoducavanja, string _brInstDozvole) 
            : base(_ime, _prezime, _datumRod, _spol, _email, _telefon, _pass)
        {
            KategorijePoducavanja = new List<Kategorija>();
            KategorijePoducavanja = _katPoducavanja;
            Rejting = 0;
            BrojPoducenihKandidata = 0;
            BrojInstruktorskeDozvole = _brInstDozvole;
        }
    }
}

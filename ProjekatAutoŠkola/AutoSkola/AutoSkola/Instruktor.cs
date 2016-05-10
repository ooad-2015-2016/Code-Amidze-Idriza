using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola
{
    
    public class Instruktor : Osoba
    {
        public List<Kategorija> KategorijePoducavanja { get; set; }
        public int Rejting { get; set; }
        public int BrojPoducenihKandidata { get; set; }
        public string BrojInstruktorskeDozvole { get; set; }

        public Instruktor(string _ime, string _prezime, DateTime _datumRod, Spol _spol, string _email, string _telefon,
                            List<Kategorija> _katPoducavanja, int _rejting, int _brojPoducKandidata, string _brInstDozvole) : base(_ime, _prezime, _datumRod, _spol, _email, _telefon)
        {
            KategorijePoducavanja = new List<Kategorija>();
            KategorijePoducavanja = _katPoducavanja;
            Rejting = _rejting;
            BrojPoducenihKandidata = _brojPoducKandidata;
            BrojInstruktorskeDozvole = _brInstDozvole;
        }
    }
}

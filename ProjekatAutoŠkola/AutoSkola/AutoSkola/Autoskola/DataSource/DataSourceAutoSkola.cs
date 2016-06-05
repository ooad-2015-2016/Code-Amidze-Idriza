using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSkola.Autoskola.Models;

namespace AutoSkola.Autoskola.DataSource
{
    public class DataSourceAutoSkola
    {

        private static List<Osoba> Osobe = new List<Osoba>()
        {
            new Instruktor("InstIme", "InstPrezime", Convert.ToDateTime("03/03/1970"), Spol.Musko, "instruktor@gmail.com", "062103102", "instruktorpass",
                            new List<Kategorija> { Kategorija.B, Kategorija.C, Kategorija.C1 }, "010011"),
            new Kandidat("InstIme", "InstPrezime", Convert.ToDateTime("03/03/1970"), Spol.Musko, "instruktor@gmail.com", "062103102", "instruktorpass",
                          "Avde Jabucice 15")
        };

        internal static List<Osoba> DajOsobe()
        {
            return Osobe;
        }

        internal static bool LoginProvjera(string mail, string pass)
        {
            foreach (var x in Osobe)
            {
                if (x.Email == mail && x.Password == pass)
                    return true;
            }
            return false;
        }
    }

}

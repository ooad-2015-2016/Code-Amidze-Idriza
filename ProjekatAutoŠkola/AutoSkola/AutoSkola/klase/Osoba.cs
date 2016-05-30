using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola
{

    public enum Spol { Musko, Zensko };
    public abstract class Osoba
    {

        
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Spol SpolOsobe { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Password { get; set; }

        public static string RandomString(int length)  // funkcija za random generiranje passworda
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //treba dodati samo da se nakon kreiranja ispisuje pass ;)
        public Osoba(string _ime, string _prezime, DateTime _datumRod, Spol _spol, string _email, string _telefon)
        {
            Ime = _ime;
            Prezime = _prezime;
            DatumRodjenja = _datumRod;
            SpolOsobe = _spol;
            Email = _email;
            Telefon = _telefon;
            Password = RandomString(4);
        }


    }
}

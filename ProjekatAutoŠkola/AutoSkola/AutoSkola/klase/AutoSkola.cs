using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSkola
{
    public class AutoSkola
    {
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public string Vlasnik { get; set; }
        public string Password { get; set; }

        public static string RandomString(int length)  // funkcija za random generiranje passworda
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public AutoSkola(string _naziv, string _lokacija, string _vlasnik)
        {
            Naziv = _naziv;
            Lokacija = _lokacija;
            Vlasnik = _vlasnik;
            Password = RandomString(4);
        }
    }
}

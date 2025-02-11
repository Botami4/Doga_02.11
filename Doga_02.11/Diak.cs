using System;

namespace IskolaAdminisztracio
{
    public class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        public int Azonosito { get; set; }

        public Diak(string nev, string osztaly, int azonosito)
        {
            Nev = nev;
            Osztaly = osztaly;
            Azonosito = azonosito;
        }

        public void TeljesNevKiirasa()
        {
            Console.WriteLine($"Diák neve: {Nev}, Osztály: {Osztaly}");
        }
    }
}

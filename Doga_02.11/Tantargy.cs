using System;

namespace IskolaAdminisztracio
{
    public class Tantargy
    {
        private string Nev { get; set; }
        private int KontaktOrak { get; set; }

        public Tantargy(string nev, int kontaktOrak)
        {
            Nev = nev;
            KontaktOrak = kontaktOrak;
        }

        public void TantargyAdatok()
        {
            Console.WriteLine($"Tantárgy: {Nev}, heti óraszám: {KontaktOrak}");
        }
    }
}

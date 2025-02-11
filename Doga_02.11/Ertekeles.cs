using System;

namespace IskolaAdminisztracio
{
    public class Ertekeles
    {
        private Diak Diak { get; set; }
        private Tantargy Tantargy { get; set; }
        private int Erdemjegy { get; set; }

        public Ertekeles(Diak diak, Tantargy tantargy, int erdemjegy)
        {
            Diak = diak;
            Tantargy = tantargy;
            Erdemjegy = erdemjegy;
        }

        public void JegyKiirasa()
        {
            Console.WriteLine($"{Diak.Nev} a {Tantargy.Nev} tantárgyból {Erdemjegy} érdemjegyet kapott.");
        }
    }
}

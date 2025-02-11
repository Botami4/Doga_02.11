using System;
using System.Collections.Generic;

namespace IskolaAdminisztracio
{
    public class Tanar
    {
        private string Nev { get; set; }
        private List<Tantargy> Tantargyak { get; set; }
        private int TanarID { get; set; }

        public Tanar(string nev, List<Tantargy> tantargyak, int tanarID)
        {
            Nev = nev;
            Tantargyak = tantargyak;
            TanarID = tanarID;
        }

        public void HozzaadTantargy(Tantargy tantargy)
        {
            Tantargyak.Add(tantargy);
            Console.WriteLine($"Tantárgy hozzáadva: {tantargy.Nev}");
        }

        public void OktatottTantargyak()
        {
            Console.WriteLine($"{Nev} az alábbi tantárgyakat oktatja:");
            foreach (var tantargy in Tantargyak)
            {
                Console.WriteLine($"- {tantargy.Nev} ({tantargy.KontaktOrak} óra/hét)");
            }
        }
    }
}

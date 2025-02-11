using System;
using System.Collections.Generic;

namespace IskolaAdminisztracio
{
    public class Osztaly
    {
        public string Nev { get; set; }
        public List<Diak> Diakok { get; set; }
        public Tanar Osztalyfonok { get; set; }

        public Osztaly(string nev, List<Diak> diakok, Tanar osztalyfonok)
        {
            if (diakok.Count < 10 || diakok.Count > 25)
            {
                throw new ArgumentException("Az osztálynak legalább 10, de legfeljebb 25 diákot kell tartalmaznia.");
            }
            Nev = nev;
            Diakok = diakok;
            Osztalyfonok = osztalyfonok;
        }

        public void HozzaadDiak(Diak diak)
        {
            if (Diakok.Count >= 25)
            {
                Console.WriteLine("A maximum diák létszám elérve, nem lehet új diákot hozzáadni.");
                return;
            }
            Diakok.Add(diak);
            Console.WriteLine($"Diák hozzáadva: {diak.Nev}");
        }

        public void OsszesDiakListazasa()
        {
            Console.WriteLine($"Osztály: {Nev} diákjai:");
            foreach (var diak in Diakok)
            {
                Console.WriteLine($"- {diak.Nev} (Azonosító: {diak.Azonosito})");
            }
        }

        public void OsztalyfonokKiirasa()
        {
            Console.WriteLine($"Osztályfőnök: {Osztalyfonok.Nev}");
            Osztalyfonok.OktatottTantargyak();
        }

        public List<Diak> GetDiakok()
        {
            return Diakok;
        }
    }
}

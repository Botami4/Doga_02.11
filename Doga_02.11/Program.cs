using System;
using System.Collections.Generic;

namespace IskolaAdminisztracio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Diak> diakok = new List<Diak>
            {
                new Diak("Kovács Béla", "10.A", 1),
                new Diak("Nagy Anna", "10.A", 2),
                new Diak("Tóth Péter", "10.A", 3),
                new Diak("Szabó Éva", "10.A", 4),
                new Diak("Farkas Gábor", "10.A", 5),
                new Diak("Horváth László", "10.A", 6),
                new Diak("Kiss Zoltán", "10.A", 7),
                new Diak("Molnár Júlia", "10.A", 8),
                new Diak("Balogh Dóra", "10.A", 9),
                new Diak("Varga Krisztina", "10.A", 10)
            };

            Tantargy matematika = new Tantargy("Matematika", 5);
            Tantargy fizika = new Tantargy("Fizika", 4);
            Tanar osztalyfonok = new Tanar("Dr. Kiss Márton", new List<Tantargy> { matematika, fizika }, 100);
            Osztaly osztaly = new Osztaly("10.A", diakok, osztalyfonok);

            osztaly.OsztalyfonokKiirasa();
            osztaly.OsszesDiakListazasa();

            Console.WriteLine("Új diákok felvétele (max 25 diák):");
            while (osztaly.Diakok.Count < 25)
            {
                Console.WriteLine("Adja meg az új diák nevét (üres sor a kilépéshez):");
                string nev = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(nev))
                    break;
                Console.WriteLine("Adja meg az osztályt:");
                string osztalyNev = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Adja meg az azonosítót (egész szám):");
                int azonosito;
                if (!int.TryParse(Console.ReadLine(), out azonosito))
                {
                    Console.WriteLine("Érvénytelen azonosító. Próbálja újra.");
                    continue;
                }
                Diak ujDiak = new Diak(nev, osztalyNev, azonosito);
                osztaly.HozzaadDiak(ujDiak);
                osztaly.OsszesDiakListazasa();
            }
            if (osztaly.Diakok.Count >= 25)
            {
                Console.WriteLine("Az osztály elérte a maximális létszámot (25 diák).");
            }

            Ertekeles ertekeles = new Ertekeles(diakok[0], matematika, 5);
            ertekeles.JegyKiirasa();

            Console.ReadKey();
        }
    }
}

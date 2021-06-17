using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<LiftMozgás> liftMozgások = new List<LiftMozgás>();
            foreach (var sor in File.ReadAllLines("lift.txt"))
            {
                liftMozgások.Add(new LiftMozgás(sor));
            }

            //3. feladat
            Console.WriteLine($"3. feladat: Összes lifthasználat: {liftMozgások.Count}");

            //4. feladat
            Console.WriteLine($"4. feladat: Időszak: " +
                $"{liftMozgások.First().Időpont.ToString("yyyy.MM.dd")} - {liftMozgások.Last().Időpont.ToString("yyyy.MM.dd")}");

            //5. feladat
            Console.WriteLine($"5. feladat: Célszint max: {liftMozgások.Max(x => x.CélSzint)}");

            //6. feladat
            Console.WriteLine($"6. feladat: ");

            Console.Write($"\tKártya száma: ");
            int kártyaSzám = int.TryParse(Console.ReadLine(), out kártyaSzám) ? kártyaSzám : 5 ;

            Console.Write($"\tcélSzint száma: ");
            int célSzint = int.TryParse(Console.ReadLine(), out célSzint) ? célSzint : 5;

            //7. feladat
            bool UtaztakE = liftMozgások.Any(x => x.Kárytaszám == kártyaSzám && x.CélSzint == célSzint);
            Console.WriteLine($"7. feladat: A(z) {kártyaSzám}. számú kártyával {(UtaztakE ? "" : "nem ")}utaztak a(z) {célSzint}. emeletre!");

            //8. feladat
            Console.WriteLine($"8. feladat: Statisztika");
            liftMozgások.GroupBy(x => x.Időpont)
                .Select(gr => new { Időpont = gr.Key, Darab = gr.Count() })
                .ToList().ForEach(x => Console.WriteLine($"\t {x.Időpont.ToString("yyyy.MM.dd")} - {x.Darab}x"));
        }
    }
}

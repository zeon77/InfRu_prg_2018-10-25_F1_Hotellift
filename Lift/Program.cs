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
        }
    }
}

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
        }
    }
}

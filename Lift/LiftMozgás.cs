using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    class LiftMozgás
    {
        public DateTime Időpont { get; set; }
        public int Kárytaszám { get; set; }
        public int IndulóSzint { get; set; }
        public int CélSzint { get; set; }

        public LiftMozgás(string sor)
        {
            string[] Splitted = sor.Split(' ');
            Időpont = DateTime.Parse(Splitted[0]);
            Kárytaszám = int.Parse(Splitted[1]);
            IndulóSzint = int.Parse(Splitted[2]);
            CélSzint = int.Parse(Splitted[3]);
        }
    }
}

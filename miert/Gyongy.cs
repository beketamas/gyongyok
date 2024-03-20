using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miert
{
    internal class Gyongy
    {
        int x, y, z, e;

        public Gyongy(string sor)
        {
            string[] tomb = sor.Split(";");
            this.x = int.Parse(tomb[0]);
            this.y = int.Parse(tomb[1]);
            this.z = int.Parse(tomb[2]);
            this.e = int.Parse(tomb[3]);
        }

        public int X => x;
        public int Y => y;
        public int Z => z;
        public int E => e;
    }
}

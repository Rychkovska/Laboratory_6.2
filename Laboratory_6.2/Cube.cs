using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_6._2
{
    public class Cube : ISolid
    {
        public double A { get; set; }

        public Cube(double a)
        {
            A = a;
        }

        public double GetVolume()
        {
            return Math.Pow(A, 3);
        }
    }
}

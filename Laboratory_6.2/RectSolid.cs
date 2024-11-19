using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_6._2
{
    public class RectSolid : ISolid
    {
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }

        public RectSolid(double c, double d, double h)
        {
            C = c;
            D = d;
            H = h;
        }

        public double GetVolume()
        {
            return C * D * H;
        }
    }
}

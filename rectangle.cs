using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class rectangle
    {
        int l, b, r;
        double pi, area;

        public rectangle(rectangle objrectangle)
        {
            l = objrectangle.l; 
            b = objrectangle.b;
            r = objrectangle.r;
            pi = objrectangle.pi;
        }
        public void AreaOfCircle()
        {
            area = pi * r * r;
        }
        public void AreaOfRectangle()
        {
            area = l * b;
        }
    }
}

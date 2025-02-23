using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework._1
{
    public class Class_constructor
    {
        int l, b, r;
        double pi, area;

        public Class_constructor()
        {
            l = 10;
            b = 20;
            r = 30;
            pi = 3.144;
        }
        public void AreaOfCirce()
        {
            area = pi * r * r;
        }
        public void PrintArea()
        {
            Console.WriteLine("Area={0}", area);
        }
    }
}

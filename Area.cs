using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    public class Area
    {
        int l, b, h, Area1;
        string FN, SN, Perimeter;
        public void add (int l, int b, int h)
        {
            Area1 = l * b;
            Console.WriteLine("Result = {0}", area1);
        }
        public void add(string FN, string SN)
        {
            Perimeter = FN + SN;
            Console.WriteLine("Result = {0}", Perimeter);
        }
    }

    }
}

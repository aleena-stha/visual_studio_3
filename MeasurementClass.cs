using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    public class MeasurementClass
    {
        int a1, b1, sum;
        string fn, sn, fullname;

        public void add(int a, int b)
        {
            sum = a + b;
            Console.WriteLine("Result = {0}", sum);
        }
        public void add(string FN, string SN)
        {
            fullname = FN + SN;
            Console.WriteLine("Result = {0}", fullname);
        }
    }
}



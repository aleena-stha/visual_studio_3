
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Summation

    {
        int fn, sn, sum;
        public void GetData()
        {
            Console.WriteLine("Enter a\n");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b\n");
            sn = int.Parse(Console.ReadLine());
        }

        public void Calculate()
        {
            sum = fn + sn;
        }

        public void PrintSum()
        {
            Console.WriteLine("{0} + {1} = {2}\n, fn, sn, sum");
        }

    }
}


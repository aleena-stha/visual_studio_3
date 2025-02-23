using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class volume
    {
        float len,vol;
        public void GetData()
        {
            Console.WriteLine("Enter len\n");
            len = float.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            vol = len * len * len;
        }
        public void PrintVol()
        {
            Console.WriteLine("Volume is ");
            Console.WriteLine("{0}\n", vol);
        }
    }
}

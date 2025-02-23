using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework._1
{
    internal class homework
    {
        float len, vol;
         public void GetData()
        {
            Console.WriteLine("Program to calculate the Volume of a Cube\nEnter len\n");
            len = float.Parse(Console.ReadLine());
        }
        public void Calculate_Volume()
        {
            vol = len * len * len;
        }

        public void Print_Volume()
        {
            Console.WriteLine("Volume = {0}",vol);
        }
    }
    Console.WriteLine("{1} * {1{ * {1} = {1}\n");

}

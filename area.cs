using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new
{
    public class area
    {
        int l, b, Multiply;
        public void GetData()
        {
            Console.WriteLine("Enter l\n");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b\n");
            b = int.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
            Multiply = l * b;
      
        }
        public void PrintMultiply()
        {
            Console.WriteLine("{1} * {2} = {2}\n", l, b, Multiply);
        }
    }
}

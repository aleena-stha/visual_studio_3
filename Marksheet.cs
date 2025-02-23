using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace homework_2
{
    internal class Marksheet
    {
        float s1, s2, s3, s4, s5, total;
        public void GetData()
        {
            Console.WriteLine("Enter the marks of s1\n");
            s1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of s1\n");
            s2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of s3\n");
            s3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of s4\n");
            s4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of s5\n");
            s5 = float.Parse(Console.ReadLine());
        }
        public void Calculate()
        {
          total = s1 + s2 + s3 + s4 + s5;
        }
        public void PrintTotal()
        {
            Console.WriteLine("{0}\n, total");
        }
    }
}

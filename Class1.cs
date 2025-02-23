using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_1
{
    internal class Class1
    {
        float length, breadth,height, area,volume;
        public void GetData()
        {
            Console.WriteLine("Enter length\n");
            length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter breadth\n");
            breadth = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter height\n");
            height = float.Parse(Console.ReadLine());
        }
        public void Calculate_Area()
        {
            area = length * breadth;
        }

        public void Calculate_Volume()
        {
            volume = length * breadth * height;
        }

        public void Display_Area()
        {
            Console.WriteLine("Area of Rectangle is {0}", area);
        }

        public void Display_Volume()
        {

            Console.WriteLine("Volume of Recytangle is  is {0}", volume);
        }
    }
}

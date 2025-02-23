using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    internal class Amount
    {
      
        double p, t, r, I, A;

        public Amount () // Default Constructor
        {
            p = 1200;
            t = 4;
            r = 7;

        }
        public Amount (double principle, double time, double rate)//parameterised constructor
        {
            p = principle;
            t = time;
            r = rate;
        }
        public Amount (Amount a1)//copy constructor
        {
            p = a1.p;
            t = a1.t;
            r = a1.r;
        }
        public void Getdata()
        {
            Console.WriteLine("Enter Principle ");
            Console.ReadLine();
            Console.WriteLine("Enter Time");
            Console.ReadLine();
            Console.WriteLine("Enter Rate");
            Console.ReadLine();

        }
        public void Calc_Interest()
        {
            I = (p * t * r) / 100;

        }
        public void Calc_Amount()
        {
            A = p + I;

        }
        public void Print_Interest()
        {
            Console.WriteLine("Interest={0}", I);
        }
        public void Print_Amount()
        {
            Console.WriteLine("Amount={0}", A);
        }

    }
}



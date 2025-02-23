//float S1, S2, S3, S4, S5;
//Console.WriteLine("Enter S1 marks");
//S1=float.Parse(Console.ReadLine());

//Console.WriteLine("Enter S2 marks");
//S2=float.Parse(Console.ReadLine());

//Console.WriteLine("Enter S3 marks");
//S3=float.Parse(Console.ReadLine());

//Console.WriteLine("Enter S4 marks");
//S4=float.Parse(Console.ReadLine());

//Console.WriteLine("Enter S5 marks");
//S5=float.Parse(Console.ReadLine());

//float total = S1 + S2 + S3 + S4 + S5;

//Console.WriteLine("{0}+{1}+{2}+{3}+{4}={5}", S1, S2, S3, S4, S5,total);

//float percentage = (S1 / total) * 100;
//Console.WriteLine("Percentage:{0}%", percentage);


using Marksheet;
using System.Runtime.Intrinsics.Arm;
{
    
    //Console.WriteLine("Marksheet")
    Summation s1 = new Summation();
    s1.GetData();
    s1.Calculate();
    s1.PrintSum();
}
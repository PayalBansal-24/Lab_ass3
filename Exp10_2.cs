using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Ass3_Exp10;

namespace Lab_Ass3_Exp10_1
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Addition: ");
            p.add(a, b);
        }
    }
}

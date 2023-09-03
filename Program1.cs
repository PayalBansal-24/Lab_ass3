using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Ass3_Exp9;

namespace Lab_Ass3_Exp9_1
{
    public class DerivedClass : Program
    {
        public void PublicMethod()
        {
            Console.WriteLine("Calling the protected method..."); 
            ProtetedMethod();
        }
        
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.PublicMethod();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp6;

namespace Exp6_1
{
     public class DerivedClass : Program
    {
        public void AccessNames()
        {
            Console.WriteLine("Full Name: " + first_name + " " +last_name);
        }
  
    
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.AccessNames();
        }
    }
}

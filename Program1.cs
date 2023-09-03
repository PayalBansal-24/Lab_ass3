using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exp5;

namespace Exp5_1
{
    internal class DerivedClass : Assembly1
    {
        public void AccountHolderName()
        {
            Console.WriteLine("Account holder name is: " + Account_holder_name);
        }
    }

    internal class Program { 
        static void Main(string[] args)
        {
            DerivedClass a = new DerivedClass();
            a.AccountHolderName();
        }
    }
}

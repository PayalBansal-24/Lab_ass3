using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp4
{
    class BaseClass
    {
        protected int bank_acc;

        protected void SetValue(int bank_acc_no)
        {
            bank_acc = bank_acc_no;
        }
    }

    class DerivedClass : BaseClass
    {
        public void AccessMembers(int bank)
        {
            Console.WriteLine("Bank account Number is: " + bank);
        }
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            Console.WriteLine("Enter your Bank account number:");
            int bank_acc = Convert.ToInt32(Console.ReadLine());
            d.SetValue(bank_acc);
            d.AccessMembers(bank_acc);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass3_Exp8
{
    internal class Program
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method calling....");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public Method is invoking..");
            PrivateMethod();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.PublicMethod();
        }
    }
}

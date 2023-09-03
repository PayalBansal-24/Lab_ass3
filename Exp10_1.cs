using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass3_Exp10
{
    public class Program
    {
        internal Program() {
            Console.WriteLine("Internal Constructor calling");
        }

        public void add(int x, int y)
        {
            int add = x + y;
            Console.WriteLine(add);
        }
        
    }
}

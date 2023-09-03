using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp3
{
    internal class Assembly1
    {
        internal string sName;
        public void studName(string name)
        {
            sName = name;
        }

        public string GetName()
        {
            return sName;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass3_Exp7
{
    public class Program
    {
        private string city;

        public Program(string city_name)
        {
            city = city_name;
        }
       
        public void SetName(string name)
        {
            city = name;
        }

        public string GetName()
        {
            return city;
        }
        static void Main(string[] args)
        {
            Program p = new Program("Mathura");
            Console.WriteLine("Before Updation: "+p.GetName());
            p.SetName("Delhi");
            Console.WriteLine("After Updation: "+p.GetName());
        }
    }
}

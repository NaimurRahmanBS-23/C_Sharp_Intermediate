using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task.Abstract_Class
{
    abstract class Abstract
    {

        public int number;
        public abstract void Print();
        public abstract void Print2(string s); 
        public static void Print(int n)
        {
            Console.WriteLine("This is a base class with number {0}",n);
        }
    }
}

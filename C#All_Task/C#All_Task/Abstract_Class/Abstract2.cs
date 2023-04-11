using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task.Abstract_Class
{
    internal class Abstract2:Abstract
    {
        public override void Print()
        {
            Console.WriteLine("This is derived class");
            
        }
        // How to use parameter in abstract class
        public override void Print2(string s)
        {
            Console.WriteLine("Print2 Method {0}",s);
        }
        public  void Print(int n)
        {
            Console.WriteLine("This is a derived class with  number {0} ",n);
        }
    }
}

using C_All_Task.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task
{
    public class Bird : Animals 
    {

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Bird()
        {
            Console.WriteLine("This is a bird class derived from animals class");
        }
        public Bird(string name,int age):base(name,age)
        { 
            this.Name = name;
        }
        public void getAge()
        {
            Console.WriteLine("This is after OverWriting");
        }

        public override void Print3()
        {
            Console.WriteLine("This is derived print3 method");
        }
        public void GetProtecetd()
        {
            Protected();
           
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task
{
    public class Animals
    {
        public string Name { get; set; }
        protected int age;
        public string color;
        

        public virtual void Print3()
        {
            Console.WriteLine("This is base method meant to be override in derived");
        }
        public Animals() {
            Console.WriteLine("animal class object has been created with default constructor");
        }
        public Animals(string name,int age) {
            this.Name = name;
            this.age = age; 

            Console.WriteLine("This is constructor with name and age");
        }
        public void getAge()
        {
            Console.WriteLine("This is before overWriting and age is {0} ",this.age);
        }
        private void Print() {
            Console.WriteLine("This is a private method");
        }
        protected void Protected() {
            Console.WriteLine("This is a protected method");

        }
    }
}

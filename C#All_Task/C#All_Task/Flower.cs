using C_All_Task.Abstract_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task
{
    internal class Flower:Bird
    {
        public string name;
        private  int id;
        protected int age;
        public void GetName()
        {
            Console.WriteLine(this.name);
        }
        protected void SetAge(int age)
        {
            this.age = age; 
        }
    }
}

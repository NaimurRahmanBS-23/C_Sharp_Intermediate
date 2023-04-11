using System;

namespace C_All_Task
{
     internal class ClassObject
    {
       public string name;
       public int age;
        public ClassObject(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
      public  void PrintObject()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);
        }
    }
}

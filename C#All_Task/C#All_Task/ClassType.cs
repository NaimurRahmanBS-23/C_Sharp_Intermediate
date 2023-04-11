using System;


namespace C_All_Task
{
    internal class ClassType
    {
        public int id;
        public string name;
        public ClassType(int id,string name) { 
            this.id = id;
            this.name = name;
        }
        public void ChangeId(int newId)
        {
            newId = 10111;
        }
        public void ChangeId(ClassType obj)
        {
           obj.id = 1329;
        }
        public void GetId()
        {
            Console.WriteLine("New id = {0}",this.id);
        }
    }
}

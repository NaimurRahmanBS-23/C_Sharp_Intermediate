using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_All_Task
{
    internal class Constructor
    {
       public List<string>customers;
       public int totalCost;
        public static int shopRate ;
        public Constructor() { 
            customers = new List<string>();
        }
        public Constructor(List<string> customers)
        {
            this.customers = customers;
        }
        public Constructor(Constructor constructor)
        {
            this.customers=constructor.customers;
            this.totalCost = constructor.totalCost;
        }
         static Constructor() { 
            shopRate = 0;
        }
    }
}

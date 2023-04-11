
using C_All_Task;
using C_All_Task.Abstract_Class;
using C_All_Task.Static_Method;
using System.Text;

namespace Program
{
    public class Program
    {

        //Enum
        enum Week
        {
            Satarday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ClassObject classobj = new ClassObject("Naimur", 23);
            Console.WriteLine(classobj.name);
            Console.WriteLine(classobj.age);
            classobj.PrintObject();

            // Structure
            var structure = new Structure();
            structure.shop.Set(1, "Myshop", 12090, 1);
            structure.shop.Print();

            // Class type-Non_primitive
            var classType = new ClassType(1, "Naimur");
            Console.WriteLine("OLd Id = {0}", classType.id);
            classType.ChangeId(classType.id);
            classType.ChangeId(classType);
            classType.GetId();

            //More on class type using different tech
            var obj = new ClassType(2,"joy");
            obj = classType;
            obj.id = 9;
            obj.name = "Brain_Station-23";
            Console.WriteLine(classType.id);
            Console.WriteLine(classType.name);

            var n = 100;
            var m = 1;
            m = n;
            m = 908;
            Console.WriteLine("This is new value of n= {0}",n);


            //Array

            var boolArray = new bool[15];
           var charArray = new char[15];
           var intArray = new int[15];
           var longArray = new long[15];
           var doubleArray = new double[15];
           var floatArray = new float[15];
           var stringArray = new string[15];
           Random rnd = new Random();
            for(int i = 0; i < 15; i++)
            {
                boolArray[i] = rnd.Next(10) >= 5;
                charArray[i] = (char)(65+rnd.Next(0,26));
                intArray[i]=rnd.Next(100);
                longArray[i]=rnd.Next(1000000000)*rnd.Next(109090090);
                doubleArray[i] = rnd.NextDouble();
                floatArray[i] = (float)10.212/rnd.Next(190);
                stringArray[i] = "ell";
            }
            for(int i=0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(charArray[i]);
            }
            var pos = 0;
           // Console.WriteLine(intArray[0]);
            while (pos<10)
            {
                if (pos == 5)
                {
                    pos++;
                    continue;
                }
                Console.WriteLine(intArray[pos++]);
            }

            //Enum examples
           
            // String to Enum
            var day1 = "Sunday";
            var day2 = "SUNDAY";
            Week week1 ,week2 ;
            if(Enum.TryParse<Week>(day1,out week1))
            {
                Console.WriteLine("{0} Converted to {1} ",day1,week1);
            }
            if (Enum.TryParse<Week>(day2,true, out week2))
            {
                Console.WriteLine("{0} Converted to {1} ", day2, week2);
            }
            // Enum to String

            var day = Week.Satarday;
            var dayInString=day.ToString();
            Console.WriteLine("Enum to String = {0}",dayInString);

            //int to enum
            int dayPositon = 2;
            week1 = (Week)dayPositon;
            Console.WriteLine("Int to Enum= {0}",week1);
            // enum to int
            dayPositon = (int)Week.Satarday;
            Console.WriteLine("Enum to int {0}",dayPositon);
            // Static vs NonStatic
            // static method accessing without creating object
            Static.Print();

            // Non static method access using object
            var obj1 = new NonStatic();
            obj1.Print();

            //List and array
            var list = new List<int>();
            list.Add(11);
            list.Add(12);
            list.Add(1);
            list.Remove(11);
            list.Sort();
            list.Capacity = 11;
            //list.Clear();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            var array=new int[11];
            array[0] = 111;
            array[1] = 92;
            var array2 = new int[12];
            Array.Copy(array,array2,array.Length);
            Array.Sort(array);
            Array.Reverse(array);
            Array.Clear(array);
            Array.BinarySearch(array, 5);
            Console.WriteLine(array2[1]);

            // String builder
            StringBuilder sb= new StringBuilder();
            sb.Append("Hello");
            sb.AppendLine(" World");
            sb.Append("I am naimur Rahman");
            Console.WriteLine(sb);
            sb.Insert(6, "BS-23 ");
            Console.WriteLine(sb);
            sb.Remove(6, 5);
            Console.WriteLine(sb);

            // Constructor
            var list2= new List<string>();
            list2.Add("Hello");
            var constructor1= new Constructor();
            var constructor2= new Constructor(list2);
            var constructor3 = new Constructor(constructor2);
            // Access Modifier
            var bird = new Animals();
            bird.color = "red";
            bird.Name = "Doyel";

            var newBird = new Bird(bird.Name,29);
            newBird.color = "green";
            newBird.GetProtecetd();


            // Multilevel inheritence overloading
            var mulLevel = new MultiLevel();
            mulLevel.Name = "IShan";
            mulLevel.color = "white";
            mulLevel.ProtectedMethod();
            mulLevel.GetProtecetd();
            //upcast and downcast

            //Upcast
            var bird2= new Bird(bird.Name,21);
            var animal2= new Animals();
            animal2 = bird2;
            Console.WriteLine(animal2.Name);
            animal2.getAge();

            // DownCasting

            var bird3= new Bird();
            bird3 = (Bird)animal2;
            Console.WriteLine(bird3.Name);
            bird3.getAge();

            // Copy memberwise
            var bird12= new Bird("Koyel",5);
            var copyBird12 = (Bird)bird12.Clone();
            copyBird12.Name = "Hira_Moni_Panna";
            Console.WriteLine("Original bird {0}= ",bird12.Name);
            Console.WriteLine("After copying and changing name {0}= ",bird12.Name);
            
            // Abstraction
            Abstract2 nAbstract= new Abstract2();
            nAbstract.Print();
            nAbstract.Print2("Naimur");
            nAbstract.Print(100);
            nAbstract.number = 1;


            // Interface
            var cow= new Cow();
            cow.AnimalSound();



            // MultiLevel With protected Access

            // Override will be found in bird class
            
            var flower = new Flower();
            flower.GetProtecetd();          string s=new("Baa");
             string ss = s;
             ss.ToLower();
             Console.WriteLine(ss.ToLower());
        } 
    
    }

    
    
}





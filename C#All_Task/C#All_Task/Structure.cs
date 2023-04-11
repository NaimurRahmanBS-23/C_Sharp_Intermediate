using System;


namespace C_All_Task
{

struct Shop
{
    public int id;
    public string name;
    public int price;
    public int quantity;
    public void Set(int id,string name, int price, int quantity)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;

    }
    public void Print()
    {
        Console.WriteLine("Shop name is {0} ",this.name);
        Console.WriteLine("Shop id is {0} ",this.id);
        Console.WriteLine("Shop Price is {0} ",this.price);
        Console.WriteLine("Quantity {0} ",this.quantity);
    }
}


    internal class Structure
    {
       public Shop shop= new Shop();
       
    }
}

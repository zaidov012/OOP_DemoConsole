using System;

public class CarSalesman : Salesman, IDev
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi, my name is {0}. I would recommend you to buy this car!", this.FullName));
    }

    public override void Buy()
    {
        Console.WriteLine(String.Format("Hi, my name is {0}. I want to buy this car!", this.FullName));
    }

    public void Develop()
    {
        Console.WriteLine("I develop myself by watcing car news and car selling videos.");
    }
}
using System;

public class PhoneSalesman : Salesman
{
    public PhoneSalesman(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi, my name is {0}. I would recommend you to buy this iPhone!", this.FullName));
    }
}
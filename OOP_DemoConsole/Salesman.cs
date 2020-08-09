using System;

public abstract class Salesman
{
    private string _firstName;
    private string _lastName;

    public string FullName
    {
        get
        {
            return string.Format("{0} {1}", _firstName, _lastName);
        }
    }

    public Salesman(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public abstract void Sell(); // abstract methods can't have a description

    public virtual void Buy() // virtual methods have a description. Inherited class can override it or not
    {
        Console.WriteLine(String.Format("Hi, my name is {0}. I want to buy this item!", FullName));
    }
}
/*
abstract class - is a class, that can have (or not have) abstract methods and properties
abstract class cannot instantiate objects (you cannot create an object of that class)
abstract class need to be inherited
abstract methods and properties need to be overriden in child classes

virtual methods:
virtual methods - methods that can be redefined in derived classess (or cannot be redefined)
virtual has an implementation (definiton) in base class
*/
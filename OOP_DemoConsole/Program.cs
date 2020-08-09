using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesmen = new List<Salesman>() { new PhoneSalesman("Steve", "Jobs"), new CarSalesman("Asif", "Zaidov"), new PcSalesman("Orxan", "Rogers")} ;
            foreach(var item in salesmen)
            {
                item.Sell();
            }

            List<IDev> selfDevelop = new List<IDev>() {new CarSalesman("Bill", "Stark"), new WebDeveloper("C#")};
            foreach(var item in selfDevelop)
            {
                item.Develop();
            }

            /*
                Polymorphism (2 types): Static and Dynamic.
                Static polymorphism - on the method level. You can create some methods with same name in the same scope, but different parameters. So, the response to a method
                is determined at the compile time

                Dynamic Polymorphism - implemented by abstract classes or interfaces and virtual functions. You can define a method in abstract class with keyword 'virtual', so you can 
                redefine it in child class(-es). And then, by using type of parent class you can unify objects of different classes (all they must be child classes of the 
                one abstract class) and use same methods for them. Of course, different classes mean different types, and the same method in these classes works not differently.

                V.2:
                Static Polymorphism is using method overloading within each class
                and
                Dynamic Polymorphism is using method overriding in many classes inheriting from a base class such as an Abstract Class or an Interface.
            */

            // CarSalesman asifCarSalesman = new CarSalesman("Asif", "Zaidov");
            // Console.WriteLine(asifCarSalesman.FullName);
            // asifCarSalesman.Sell();
            // asifCarSalesman.Buy(); // overriden Buy() method

            // PhoneSalesman steveCarSalesman = new PhoneSalesman("Steve", "Jobs");
            // Console.WriteLine(steveCarSalesman.FullName);
            // steveCarSalesman.Sell();
            // steveCarSalesman.Buy(); // base virtual not overriden Buy() method
        }
    }
}

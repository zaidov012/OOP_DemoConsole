# OOP_Demo
This project shows using principles of OOP in a little project

Definition of each principle was written in comment block in files of the project

## Inheritance

**Inheritance** is an important pillar of OOP(Object Oriented Programming). It is the mechanism in C# by which one class is allowed to inherit the features(fields and methods) of another class.

Important terminology:

Super Class: The class whose features are inherited is known as super class(or a base class or a parent class).

Sub Class: The class that inherits the other class is known as subclass(or a derived class, extended class, or child class). The subclass can add its own fields and methods in addition to the superclass fields and methods.

Reusability: Inheritance supports the concept of “reusability”, i.e. when we want to create a new class and there is already a class that includes some of the code that we want, we can derive our new class from the existing class. By doing this, we are reusing the fields and methods of the existing class.

## Polymorphism

**Polymorphism** (2 types): Static and Dynamic.

Static polymorphism - on the method level. You can create some methods with same name in the same scope, but different parameters. So, the response to a method
is determined at the compile time

Dynamic Polymorphism - implemented by abstract classes or interfaces and virtual functions. You can define a method in abstract class with keyword 'virtual', so you can redefine it in child class(-es). And then, by using type of parent class you can unify objects of different classes (all they must be child classes of the one abstract class) and use same methods for them. Of course, different classes mean different types, and the same method in these classes works not differently.

V.2:
Static Polymorphism is using method overloading within each class and Dynamic Polymorphism is using method overriding in many classes inheriting from a base class such as an Abstract Class or an Interface.

## Encapsulation

**Encapsulation** is defined as the wrapping up of data under a single unit. It is the mechanism that binds together code and the data it manipulates. In a different way, encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.

* Technically in encapsulation, the variables or data of a class are hidden from any other class and can be accessed only through any member function of own class in which they are declared.
* As in encapsulation, the data in a class is hidden from other classes, so it is also known as data-hiding.
* Encapsulation can be achieved by: Declaring all the variables in the class as private and using C# Properties in the class to set and get the values of variables.

## Abstraction

Data Abstraction is the property by virtue of which only the essential details are exhibited to the user. The trivial or the non-essentials units aren’t exhibited to the user.

Data Abstraction may also be defined as the process of identifying only the required characteristics of an object ignoring the irrelevant details. The properties and behaviors of an object differentiate it from other objects of similar type and also help in classifying/grouping the objects.

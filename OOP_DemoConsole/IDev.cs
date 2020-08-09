public interface IDev
{
        void Develop();
}

/*
    Interface - cannot have constructors and fields. Only properties and methods
    All members of an interface needed to be implemented in class that uses this interface
    Difference between abstract class and interface is that:
        a) interface cannot have constuctors and fields
        b) abstract class groups related classes. So, all child classes have to override abstract methods, and there is no other way
           interfaces group not onyl related classes. It means, if two different classes need to override same method(/s), we can use interfaces for them
*/
using System;

// Abstract class vs Interface
// Abstract class - unifies realted classes. All abstract methods needed to be overriden in child classes.
// Interface - unifies unrelated group of objects. All methods in the interface needed to be overriden in classes that implement interface
public abstract class Developer
{
    private string _devLanguage;

    public string DevLanguage
    {
        get
        {
            return _devLanguage;
        }
    }

    public Developer(string devLanguage)
    {
        this._devLanguage = devLanguage;
    }

    public abstract void Code(); // abstract method - need to be overriden
}
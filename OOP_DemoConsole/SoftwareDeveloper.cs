using System;

public class SoftwareDeveloper : Developer
{
    public SoftwareDeveloper(string devLanguage) : base(devLanguage)
    {

    }

    public override void Code()
    {
        Console.WriteLine(String.Format("I code my projects on {0}.", this.DevLanguage));
    }
}
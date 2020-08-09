using System;

public class WebDeveloper : Developer, IDev
{
    public WebDeveloper(string devLanguage) : base(devLanguage)
    {

    }

    public override void Code()
    {
        Console.WriteLine(String.Format("I code my projects on {0}.", this.DevLanguage));
    }

    public void Develop()
    {
        Console.WriteLine("I developing myself watching web development courses on Udemy.");
    }
}
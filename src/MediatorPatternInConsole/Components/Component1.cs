namespace MediatorPatternInConsole.Components;

public class Component1 : BaseComponent
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A.");
        _mediator.Notify(this, "A");
    }

    public void DoB() 
    {
        Console.WriteLine("Component 1 does B.");

        _mediator.Notify(this, "B");
    }
}

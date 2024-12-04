using Behavioral.Chain_of_Responsibility.Abstract_Class;

namespace Behavioral.Chain_of_Responsibility.Concrete_Handlers;

// Concrete Handlers
public class ErrorLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 3; // Only Handle Error Messages
    }

    protected override void Write(string message)
    {
        Console.WriteLine("ERROR: " + message);
    }
}
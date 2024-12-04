using Behavioral.Chain_of_Responsibility.Abstract_Class;

namespace Behavioral.Chain_of_Responsibility.Concrete_Handlers;

// Concrete Handlers
public class WarningLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 2; // Only Handle Warning Messages
    }

    protected override void Write(string message)
    {
        Console.WriteLine("WARNING: " + message);
    }
}
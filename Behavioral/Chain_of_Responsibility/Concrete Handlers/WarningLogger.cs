namespace Behavioral.Chain_of_Responsibility;

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
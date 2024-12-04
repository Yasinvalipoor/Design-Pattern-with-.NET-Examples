namespace Behavioral.Chain_of_Responsibility;

// Concrete Handlers
public class InfoLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 1; // Only Handle Info Messages
    }

    protected override void Write(string message)
    {
        Console.WriteLine("INFO: " + message);
    }
}
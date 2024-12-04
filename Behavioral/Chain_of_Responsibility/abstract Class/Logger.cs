namespace Behavioral.Chain_of_Responsibility;

public abstract class Logger
{
    protected Logger? _nextLogger;

    public void SetNext(Logger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public void LogMessage(int level, string message)
    {
        if (CanHandle(level))
        {
            Write(message);
        }
        else if (_nextLogger != null)
        {
            _nextLogger.LogMessage(level, message);
        }
    }

    protected abstract bool CanHandle(int level);
    protected abstract void Write(string message);
}
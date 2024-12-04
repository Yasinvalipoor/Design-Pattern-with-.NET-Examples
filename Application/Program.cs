using Behavioral.Chain_of_Responsibility;




Console.WriteLine("\n====================== Creational ======================\n");


Console.WriteLine("\n====================== Structural ======================\n");


Console.WriteLine("\n====================== Behavioral ======================\n");


Console.WriteLine("Chain of Responsibility\n");

// Creating a Chain Of Concrete Handlers
Logger infoLogger = new InfoLogger();
Logger warningLogger = new WarningLogger();
Logger errorLogger = new ErrorLogger();


infoLogger.SetNext(warningLogger);
warningLogger.SetNext(errorLogger);

// ارسال پیام‌ها به زنجیره
infoLogger.LogMessage(1, "This is an informational message.");
infoLogger.LogMessage(2, "This is a warning message.");
infoLogger.LogMessage(3, "This is an error message.");

Console.WriteLine("\n--------------------------------");



Console.ReadLine();
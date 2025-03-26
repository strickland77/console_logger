namespace Singleton
{
    public enum LogLevel
    {
        Error,
        Warning,
        Comment
    }
    public class SingletonLogger
    {
        static SingletonLogger instance;

        private SingletonLogger()
        {
        }
        
        public static SingletonLogger Instance()
        {
            if (instance == null)
            {
                instance = new SingletonLogger();
            }

            return instance;
        }

        public void Log(Singleton.LogLevel level, string message)
        {
            switch(level)
            {
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    Environment.Exit(1);
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case LogLevel.Comment:
                Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                    break;
                default:
                    break;
            }
        }
    }

    public static class StaticLogger
    {
        static StaticLogger()
        {

        }

        public static void Log(Singleton.LogLevel level, string message)
        {
            switch(level)
            {
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    Environment.Exit(1);
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ResetColor();
                    break;
                case LogLevel.Comment:
                Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                    break;
                default:
                    break;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating Singleton logger...");
            SingletonLogger singletonLogger = SingletonLogger.Instance();

            singletonLogger.Log(LogLevel.Comment, "Test singleton comment...");
            singletonLogger.Log(LogLevel.Warning, "Test singleton warning...");
            //singletonLogger.Log(LogLevel.Error, "Test singleton error...");
            singletonLogger.Log(LogLevel.Comment, "Test singleton comment again...");

            Console.WriteLine("Using Static logger...");

            StaticLogger.Log(LogLevel.Comment, "Test static comment...");
            StaticLogger.Log(LogLevel.Warning, "Test static warning...");
            StaticLogger.Log(LogLevel.Error, "Test static error...");
            StaticLogger.Log(LogLevel.Comment, "Test static comment again...");
        }
    }
}
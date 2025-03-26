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
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ForegroundColor = ConsoleColor.White;
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

    public class Logger
    {
        public Logger instance;

        public Logger()
        {

        }

        public void Log(Singleton.LogLevel level, string message)
        {
            switch(level)
            {
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ForegroundColor = ConsoleColor.White;
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
        private static Logger instance;

        static StaticLogger()
        {
            instance = new Logger();
        }

        public static Logger Instance()
        {
            return instance;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating Singleton logger...");
            SingletonLogger singletonLogger = SingletonLogger.Instance();

            singletonLogger.Log(LogLevel.Comment, "Test comment...");
            singletonLogger.Log(LogLevel.Warning, "Test warning...");
            //singletonLogger.Log(LogLevel.Error, "Test error...");
            singletonLogger.Log(LogLevel.Comment, "Test comment again...");

            Console.WriteLine("Creating Static logger...");
            Logger staticLogger = StaticLogger.Instance();

            staticLogger.Log(LogLevel.Comment, "Test comment...");
            staticLogger.Log(LogLevel.Warning, "Test warning...");
            staticLogger.Log(LogLevel.Error, "Test error...");
            staticLogger.Log(LogLevel.Comment, "Test comment again...");


        }
    }
}
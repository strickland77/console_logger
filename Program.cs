namespace Singleton
{
    public class Logger
    {
        static Logger instance;

        public const int Error = 1;
        public const int Warning = 2;
        public const int Comment = 3;

        private Logger()
        {

        }
        
        public static Logger Instance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void Log(int level, string message)
        {
            switch(level)
            {
                case Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                    break;
                case Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(message);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Comment:
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
            Console.WriteLine("Creating logger...");
            Logger logger = Logger.Instance();

            logger.Log(Logger.Comment, "Test comment...");
            logger.Log(Logger.Warning, "Test warning...");
            logger.Log(Logger.Error, "Test error...");
            logger.Log(Logger.Comment, "Test comment again...");
        }
    }
}
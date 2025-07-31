
namespace DesignPatternsImplementation.Singleton
{

 // Logger class implemented using the Singleton Design Pattern.
 // Ensures only one instance of Logger exists throughout the application.
    public sealed class Logger
    {
        private static Logger? _instance = null;
        private static readonly object _lock = new object(); // thread-safe

        // Private constructor prevents instantiation from other classes
        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        // Public property to get the single instance of Logger.
        // Uses double-check locking to ensure thread safety.
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to log a message.
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
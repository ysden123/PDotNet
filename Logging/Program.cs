using Serilog;

namespace StulSoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/Logging.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            Console.WriteLine("Hello!");

            Log.Information("Entering the application");
        }
    }
}
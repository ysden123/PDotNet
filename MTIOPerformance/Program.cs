using Serilog;

namespace MTIOPerformance
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .Enrich.WithThreadId()
               .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss:FFF} {Level:u3}] {SourceContext} [{ThreadId}] {Message:lj}{NewLine}{Exception}")
               .WriteTo.File("logs/MTIOPerformance.log",
               rollingInterval: RollingInterval.Day,
               outputTemplate: "[{Timestamp:HH:mm:ss:FFF} {Level:u3}] {SourceContext} [{ThreadId}] {Message:lj}{NewLine}{Exception}")
           .CreateLogger();

            Log.Information("Started");

            Service.CreateFilesSync();
            await Service.CreateFilesAsync();
        }
    }
}

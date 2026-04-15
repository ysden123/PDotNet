namespace ClassMSTests;

// Example of a Singleton class
public sealed class ConfigurationManager
{
    // 1. Static variable to hold the single instance of the class
    private static ConfigurationManager? instance = null;

    // 2. A synchronization object to ensure thread-safety during instance creation
    private static readonly object lockObject = new();

    // Configuration settings (example data)
    public string ConnectionString { get; private set; }
    public int TimeoutSeconds { get; private set; }

    // 3. Private constructor prevents direct instantiation from outside
    private ConfigurationManager()
    {
        // Initialize configuration data here. 
        // In a real application, this would involve reading settings from 
        // a file, database, or environment variables.
        ConnectionString = "Data Source=ServerName;Initial Catalog=DBName;";
        TimeoutSeconds = 30;
    }

    // 4. Public static method to provide the global access point
    public static ConfigurationManager Instance
    {
        get
        {
            // Double-checked locking for thread safety and performance
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
            }
            return instance;
        }
    }

    // Example method to demonstrate usage
    public void DisplaySettings()
    {
        Console.WriteLine($"Connection String: {ConnectionString}");
        Console.WriteLine($"Timeout: {TimeoutSeconds} seconds");
    }
}

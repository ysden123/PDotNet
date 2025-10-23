namespace ClassTests;

public class ConfigurationManagerTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Access the single instance via the static Instance property
        ConfigurationManager config1 = ConfigurationManager.Instance;

        // Accessing it again returns the SAME instance
        ConfigurationManager config2 = ConfigurationManager.Instance;

        // Verify that both variables point to the same object
        Console.WriteLine(object.ReferenceEquals(config1, config2)); // Output: True
        Assert.That(object.ReferenceEquals(config1, config2), Is.True);

        // Use the instance
        config1.DisplaySettings();
    }
}

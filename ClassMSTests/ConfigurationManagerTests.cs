namespace ClassMSTests;

[TestClass]
public class ConfigurationManagerTests
{
    [TestMethod]
    public void Test1()
    {
        // Access the single instance via the static Instance property
        ConfigurationManager config1 = ConfigurationManager.Instance;

        // Accessing it again returns the SAME instance
        ConfigurationManager config2 = ConfigurationManager.Instance;

        // Verify that both variables point to the same object
        Console.WriteLine(ReferenceEquals(config1, config2)); // Output: True
        Assert.IsTrue(ReferenceEquals(config1, config2));

        // Use the instance
        config1.DisplaySettings();
    }
}

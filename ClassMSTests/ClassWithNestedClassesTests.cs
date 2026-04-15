namespace ClassMSTests;

[TestClass]
public class ClassWithNestedClassesTests
{
    private ClassWithNestedClasses? _classWithNestedClasses;
    
    [TestInitialize]
    public void TestInitialize()
    {
        _classWithNestedClasses = new ClassWithNestedClasses();
    }

    [TestMethod]
    public void TestPlayWithCount()
    {
        int result = _classWithNestedClasses!.PlayWithCount();
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void TestPlayWithCount2()
    {
        int result = _classWithNestedClasses!.PlayWithCount2();
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void TestPlayWithString()
    {
        string result = _classWithNestedClasses!.PlayWithString();
        Assert.AreEqual("Current count is: 1", result);
    }
}

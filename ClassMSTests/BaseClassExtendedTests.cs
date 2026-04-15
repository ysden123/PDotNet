namespace ClassMSTests;

[TestClass]
public class BaseClassExtendedTests
{
    [TestMethod]
    public void Test1()
    {
        BaseClass baseClass = new();
        Assert.AreEqual("This is the BaseClass.", baseClass.GetInfo());
        Assert.AreEqual("More info from BaseClass.", baseClass.GetMoreInfo());

        BaseClassExtended baseClassExtended = new();
        Assert.AreEqual("This is the BaseClassExtended.", baseClassExtended.GetInfo());
        Assert.AreEqual("More info from BaseClass.", baseClassExtended.GetMoreInfo());  // Same as base class!!!
    }
}

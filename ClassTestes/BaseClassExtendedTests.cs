namespace ClassTests;

public class BaseClassExtendedTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        BaseClass baseClass = new ();
        Assert.That(baseClass.GetInfo(), Is.EqualTo("This is the BaseClass."));
        Assert.That(baseClass.GetMoreInfo(), Is.EqualTo("More info from BaseClass."));

        BaseClassExtended baseClassExtended = new ();
        Assert.That(baseClassExtended.GetInfo(), Is.EqualTo("This is the BaseClassExtended."));
        Assert.That(baseClassExtended.GetMoreInfo(), Is.EqualTo("More info from BaseClass."));  // Same as base class!!!
    }
}

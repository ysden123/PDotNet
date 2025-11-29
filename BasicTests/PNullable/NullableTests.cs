namespace StulSoft.BasicTests.PNullable;

public class NullableTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string? s = null;

        int? length = s?.Length;
        Assert.That(length, Is.Null);
    }
}

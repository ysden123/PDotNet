namespace StulSoft.BasicTests.PLinq;

public class LineListToDictionaryTest
{
    private static readonly string[] _lines = [
        "left=right",
        "first=second",
        "test=true"
        ];

    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Split each line by '=' and create a dictionary from the resulting key-value pairs.
    /// </summary>
    [Test]
    public void Test1()
    {
        var dictionary1= _lines
            .Select(line => line.Split('='))
            .ToDictionary(parts => parts[0], parts => parts[1]);
        Assert.That(dictionary1, Is.Not.Null);
        Assert.That(dictionary1, Has.Count.EqualTo(3));
        Assert.That(dictionary1["left"], Is.EqualTo("right"));
        Assert.That(dictionary1["first"], Is.EqualTo("second"));
        Assert.That(dictionary1["test"], Is.EqualTo("true"));
    }
}

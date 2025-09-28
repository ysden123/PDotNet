
namespace StulSoft.BasicTests;

public class LinqService
{
    private static readonly string[] _greetings = ["hello world", "hello LINQ", "hello Apress"];
    public static IList<string>? GetGreetingsFromArray()
    {
        
        var items =
            from greeting in _greetings
            where greeting.EndsWith("LINQ")
            select greeting;
        return [.. items];
    }
    public static IList<string>? GetGreetingsFromList()
    {
        var items =
            from greeting in _greetings
            where !greeting.EndsWith("LINQ")
            select greeting;
        return [.. items];
    }

    public static int[] ConvertStringsToIntsAndSortIt()
    {
        var strings = new string[] { "0042", "17", "52" };
        return strings.Select(s => Int32.Parse(s)).OrderBy(i => i).ToArray();
    }
}

public class LinqTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetGreetingsFromArrayTest()
    {
        var result = LinqService.GetGreetingsFromArray();
        Assert.That(result, Is.Not.Null);
        Assert.That(result!, Has.Count.EqualTo(1));
        Assert.That(result!, Contains.Item("hello LINQ"));
    }

    [Test]
    public void GetGreetingsFromListTest()
    {
        var result = LinqService.GetGreetingsFromList();
        Assert.That(result, Is.Not.Null);
        Assert.That(result!, Has.Count.EqualTo(2));
        Assert.That(result!, Contains.Item("hello world"));
        Assert.That(result!, Contains.Item("hello Apress"));
    }

    [Test]
    public void ConvertStringsToIntsAndSortItTest()
    {
        var result = LinqService.ConvertStringsToIntsAndSortIt();
        Assert.That(result, Is.Not.Null);
        Assert.That(result, Has.Length.EqualTo(3));
        Assert.That(result, Is.EqualTo([17, 42, 52 ]));
    }
}

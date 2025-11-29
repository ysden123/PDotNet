namespace StulSoft.BasicTests.PLinq;

public class LinqService
{
    private static readonly string[] _greetings = ["hello world", "hello LINQ", "hello Apress"];
    /// <summary>
    /// Returns greetings that end with "LINQ" as a list.
    /// </summary>
    /// <returns>greetings that end with "LINQ" as a list</returns>
    public static IList<string>? GetGreetingsFromArray()
    {

        var items =
            from greeting in _greetings
            where greeting.EndsWith("LINQ")
            select greeting;
        return [.. items];
    }
    
    /// <summary>
    /// Retrieves a collection of greetings that end with the string "LINQ" as query.
    /// </summary>
    /// <remarks>This method uses a LINQ query to filter greetings from an internal collection. If no
    /// greetings match the condition, the method returns an empty collection.</remarks>
    /// <returns>An <see cref="IEnumerable{T}"/> of strings containing greetings that end with "LINQ", or <see langword="null"/>
    /// if the internal collection is uninitialized.</returns>
    public static IEnumerable<string>? GetGreetingsFromArrayQuery()
    {

        var items =
            from greeting in _greetings
            where greeting.EndsWith("LINQ")
            select greeting;
        return items;
    }

    /// <summary>
    /// Retrieves a list of greetings that do not end with the string "LINQ".
    /// </summary>
    /// <returns>A list of greetings as strings, excluding those that end with "LINQ".  Returns <see langword="null"/> if the
    /// source collection is uninitialized.</returns>
    public static IList<string>? GetGreetingsFromList()
    {
        var items =
            from greeting in _greetings
            where !greeting.EndsWith("LINQ")
            select greeting;
        return [.. items];
    }

    /// <summary>
    /// Converts an array of numeric strings to integers and returns the integers sorted in ascending order.
    /// </summary>
    /// <remarks>Each string in the input array must represent a valid integer. If any string cannot be parsed
    /// as an integer,  an exception will be thrown.</remarks>
    /// <returns>An array of integers sorted in ascending order, converted from the original array of numeric strings.</returns>
    public static int[] ConvertStringsToIntsAndSortIt()
    {
        var strings = new string[] { "0042", "17", "52" };
        return [.. strings.Select(s => Int32.Parse(s)).OrderBy(i => i)];
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
    public void GetGreetingsFromArrayQueryTest()
    {
        var result = LinqService.GetGreetingsFromArrayQuery();
        Assert.That(result, Is.Not.Null);
        Assert.That(result!.ToList(), Has.Count.EqualTo(1));
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
        Assert.That(result, Is.EqualTo([17, 42, 52]));
    }
}

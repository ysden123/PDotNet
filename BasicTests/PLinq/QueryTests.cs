namespace StulSoft.BasicTests.PLinq;

public class QueryTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void QueryTest()
    {
        List<int> numbers = [];

        var query = from number in numbers select number;

        Assert.That(query.Count(), Is.Zero);

        numbers.Add(1);
        numbers.Add(2);

        Assert.That(query.Count(), Is.EqualTo(2));

        numbers.Add(3);
        numbers.Add(4);

        Assert.That(query.Count(), Is.EqualTo(4));
    }
}

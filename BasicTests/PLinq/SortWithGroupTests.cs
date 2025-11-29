namespace StulSoft.BasicTests.PLinq;

public class SortWithGroupTests
{
    private record MyData
    {
        public required string Name { get; init; }
        public required int Value { get; init; }
    }

    private readonly List<MyData> _myData = 
        [
            new MyData { Name = "Z", Value = 3 },
            new MyData { Name = "D", Value = 3 },
            new MyData { Name = "A", Value = 3 },
            new MyData { Name = "Yy", Value = 2 },
            new MyData { Name = "Aa", Value = 2 }
        ];
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DoubleOrderByTest()
    {
        var result = (from myData in _myData
        orderby myData.Value descending, myData.Name ascending
        select myData).ToList();

        Assert.That(result, Is.Not.Null);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(result[0], Is.EqualTo(new MyData { Name = "A", Value = 3 }));
            Assert.That(result[1], Is.EqualTo(new MyData { Name = "D", Value = 3 }));
            Assert.That(result[2], Is.EqualTo(new MyData { Name = "Z", Value = 3 }));
            Assert.That(result[3], Is.EqualTo(new MyData { Name = "Aa", Value = 2 }));
            Assert.That(result[4], Is.EqualTo(new MyData { Name = "Yy", Value = 2 }));
        }
    }
}

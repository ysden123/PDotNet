namespace StulSoft.BasicTests.PLinq;

public class AnonymusTypeTests
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
    public void TestSelectAnonymus()
    {
        var query = from myData in _myData
                    select new { UpdatedName= myData.Name + " - updated", DoubleValue = myData.Value * 2, FirstLetter = myData.Name[0] };
        var result = query.ToList();
        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.UpdatedName}, Value: {item.DoubleValue}, FirstLetter = {item.FirstLetter}");
        }
        Assert.That(result, Is.Not.Null);
    }
}

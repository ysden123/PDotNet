namespace StulSoft.BasicTests;


public class CollectionSortTests
{
    record Object4Sort
    {
        public required string Name { get; init; }
        public required int Age { get; init; }
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SortOrdinalTest()
    {
        List<Object4Sort> list = 
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        list.Sort((a,b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

        Assert.That(list[0].Name, Is.EqualTo("Name2"));
        Assert.That(list[1].Name, Is.EqualTo("name1"));
        Assert.That(list[2].Name, Is.EqualTo("name3"));
    }

    [Test]
    public void SortOrdinalIgnoreCaseTest()
    {
        List<Object4Sort> list = 
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        list.Sort((a,b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));

        Assert.That(list[0].Name, Is.EqualTo("name1"));
        Assert.That(list[1].Name, Is.EqualTo("Name2"));
        Assert.That(list[2].Name, Is.EqualTo("name3"));
    }
}

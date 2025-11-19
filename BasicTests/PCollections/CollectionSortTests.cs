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

        list.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));

        using (Assert.EnterMultipleScope())
        {
            Assert.That(list[0].Name, Is.EqualTo("Name2"));
            Assert.That(list[1].Name, Is.EqualTo("name1"));
            Assert.That(list[2].Name, Is.EqualTo("name3"));
        }

        List<Object4Sort> list2 =
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        list2.Sort((a, b) => string.CompareOrdinal(a.Name, b.Name));

        using (Assert.EnterMultipleScope())
        {
            Assert.That(list2[0].Name, Is.EqualTo("Name2"));
            Assert.That(list2[1].Name, Is.EqualTo("name1"));
            Assert.That(list2[2].Name, Is.EqualTo("name3"));
        }
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

        list.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));

        using (Assert.EnterMultipleScope())
        {
            Assert.That(list[0].Name, Is.EqualTo("name1"));
            Assert.That(list[1].Name, Is.EqualTo("Name2"));
            Assert.That(list[2].Name, Is.EqualTo("name3"));
        }
    }

    [Test]
    public void SortWithLINQTest()
    {
        List<Object4Sort> list =
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        var query = from item in list
                    orderby item.Name
                    select item;
        var sortedList = query.ToList();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(sortedList[0].Name, Is.EqualTo("name1"));
            Assert.That(sortedList[1].Name, Is.EqualTo("Name2"));
            Assert.That(sortedList[2].Name, Is.EqualTo("name3"));
        }
    }

    [Test]
    public void SortWithLINQ2Test()
    {
        List<Object4Sort> list =
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        var sortedList = (from item in list
                          orderby item.Name
                          select item).ToList();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(sortedList[0].Name, Is.EqualTo("name1"));
            Assert.That(sortedList[1].Name, Is.EqualTo("Name2"));
            Assert.That(sortedList[2].Name, Is.EqualTo("name3"));
        }
    }

    [Test]
    public void SortWithLINQ3Test()
    {
        List<Object4Sort> list =
        [
            new Object4Sort() { Name = "name3", Age = 30 },
            new Object4Sort() { Name = "name1", Age = 10 },
            new Object4Sort() { Name = "Name2", Age = 20 }
        ];

        var sortedList = (from item in list
                          orderby item.Name
                          descending
                          select item).ToList();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(sortedList[0].Name, Is.EqualTo("name3"));
            Assert.That(sortedList[1].Name, Is.EqualTo("Name2"));
            Assert.That(sortedList[2].Name, Is.EqualTo("name1"));
        }
    }
}

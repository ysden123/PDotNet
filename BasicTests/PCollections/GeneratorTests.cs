namespace StulSoft.BasicTests;

public class GeneratorTests
{
    private static class Generator
    {
        private static int SomeFunction(int i)
        {
            Console.WriteLine($"SomeFunction for {i}");
            return i * 2; 
        }
        public static IEnumerable<int> Generate()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
        public static IEnumerable<int> Generate2()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return SomeFunction(i);
            }
        }
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var list = Generator.Generate().ToList();

        using (Assert.EnterMultipleScope())
        {
            Assert.That(list.Count, Is.EqualTo(10));
            for (int i = 0; i < 10; i++)
            {
                Assert.That(list[i], Is.EqualTo(i));
            }
        }
    }

    [Test]
    public void Test2()
    {
        Console.WriteLine("==>Test2");
        IEnumerable<int> enumerabledList = Generator.Generate2();
        Console.WriteLine("Before loop");
        foreach(var item in enumerabledList)
        {
            Console.WriteLine($"Item: {item}");
        }
        Console.WriteLine("After loop");
    }
}

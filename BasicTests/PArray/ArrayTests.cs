namespace StulSoft.BasicTests;

public class ArrayTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void OneDimensionArrayTest()
    {
        int[] arr = [1, 2, 3, 4, 5];
        Assert.That(arr, Has.Length.EqualTo(5));
        Assert.That(arr[0], Is.EqualTo(1));

        var result = Array.Find<int>(arr, static i => i > 3);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void TwoDimensionArrayTest()
    {
        int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Assert.That(arr, Has.Length.EqualTo(6));
        using (Assert.EnterMultipleScope())
        {
            Assert.That(arr.GetLength(0), Is.EqualTo(2));
            Assert.That(arr.GetLength(1), Is.EqualTo(3));
            Assert.That(arr[0, 0], Is.EqualTo(1));
            Assert.That(arr[1, 2], Is.EqualTo(6));
        }
    }

    [Test]
    public void TwoDimensionArrayTest2()
    {
        int[,] arr = new int[2, 2];
        for (int i = 0; i < 2; ++i)
        {
            for (int j = 0; j < 2; ++j)
            {
                arr[i, j] = i * 2 + j + 1;
            }
        }
        Assert.That(arr, Has.Length.EqualTo(4));
        using (Assert.EnterMultipleScope())
        {
            Assert.That(arr.GetLength(0), Is.EqualTo(2));
            Assert.That(arr.GetLength(1), Is.EqualTo(2));
            Assert.That(arr[0, 0], Is.EqualTo(1));
            Assert.That(arr[1, 1], Is.EqualTo(4));
        }
    }

    [Test]
    public void ClassArrayTest()
    {
        Array strings = Array.CreateInstance(typeof(string), 3);
        strings.SetValue("one", 0);
        strings.SetValue("two", 1);
        strings.SetValue("three", 2);
        Assert.That(strings.Length, Is.EqualTo(3));
        Assert.That(strings.GetValue(0), Is.EqualTo("one"));

        string? result = Array.Find<string>((string[])strings, static s => s != null && s.StartsWith('t'));

        Assert.That(result, Is.EqualTo("two"));
    }

    [Test]
    public void TwoDotsArrayTest()
    {
        int[] ar1 = [1, 2, 3];
        int[] ar2 = [10, 20, 30];
        int[] ar3 = [100, 200, 300];

        int[] arr = [.. ar1, .. ar2, .. ar3];   // 1,2,3,10,20,30,100,200,300
        Assert.That(arr, Has.Length.EqualTo(9));
        Assert.That(arr[0], Is.EqualTo(1));
        Assert.That(arr[3], Is.EqualTo(10));
        Assert.That(arr[6], Is.EqualTo(100));

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

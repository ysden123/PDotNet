namespace StulSoft.BasicTests.PCollections
{
    internal class CollectionExTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RemoveOddItemsTest()
        {
            List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Console.WriteLine("Original collection:");
            numbers.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            // Remove odd numbers.
            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                if (numbers[index] % 2 == 1)
                {
                    // Remove the element by specifying
                    // the zero-based index in the list.
                    numbers.RemoveAt(index);
                }
            }
            Console.WriteLine("Changed collection:");
            numbers.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
        }
    }
}

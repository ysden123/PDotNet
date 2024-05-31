namespace StulSoft.BasicTests.PCollections
{
    internal class CollectionExTests
    {
        private record Person(string name, int age);

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

        [Test]
        public void FilteringTest()
        {
#pragma warning disable IDE0090
            var dic1 = new Dictionary<string, List<Person>>()
            {
                {"name1", new List<Person>()
                    {
                        new Person("name1", 1),
                        new Person("name1", 2),
                        new Person("name1", 3)
                    }
                },
                {"name2", new List<Person>()
                    {
                        new Person("name2", 10),
                        new Person("name2", 20)
                    }
                }
            };

            foreach (var item in dic1)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

            var dic2 = dic1.Where(item => item.Key == "name1").ToDictionary<string, List<Person>>();
            Console.WriteLine("selected 1");
            foreach (var item in dic2)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

            var dic3 = (from item in dic1
                       where item.Key == "name1"
                       select item).ToDictionary<string,List<Person>>();
            Console.WriteLine("selected 2");
            foreach (var item in dic3)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}

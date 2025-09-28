namespace StulSoft.BasicTests;

public record Person(string Name, string City);

public class GroupByTests
{
    private static List<Person> people =
    [
        new("Иван", "Москва"),
        new( "Анна", "Москва"),
        new ("Петр", "Санкт-Петербург"),
        new("Ольга", "Казань"),
        new("Сергей", "Казань")
    ];

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GroupByMethodTest()
    {
        // Группируем людей по городу
        var grouped = people.GroupBy(p => p.City);

        Assert.That(grouped, Is.Not.Null);
        Assert.That(grouped.Count(), Is.EqualTo(3));
        Assert.That(grouped.First(g => g.Key == "Москва").Count(), Is.EqualTo(2));

        foreach (var group in grouped)
        {
            Console.WriteLine($"Город: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine($"  {person.Name}");
            }
        }
    }

    [Test]
    public void GroupByQueryTest()
    {
        // Группируем людей по городу с использованием синтаксиса запроса
        var grouped =
            from person in people
            group person by person.City into cityGroup
            select cityGroup;

        Assert.That(grouped, Is.Not.Null);
        Assert.That(grouped.Count(), Is.EqualTo(3));
        Assert.That(grouped.First(g => g.Key == "Москва").Count(), Is.EqualTo(2));

        foreach (var group in grouped)
        {
            Console.WriteLine($"Город: {group.Key}");
            foreach (var person in group)
            {
                Console.WriteLine($"  {person.Name}");
            }
        }
    }
}

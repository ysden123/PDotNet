namespace StulSoft.BasicTests.PDateTime
{
    internal class DateTimeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDateTimeDifToStr()
        {
            DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 15);
            DateTime date2 = new DateTime(2010, 1, 1, 9, 30, 30);
            var dif = date2-date1;
            Console.WriteLine($"Hours: {dif.Hours}");
            Console.WriteLine($"Minutes: {dif.Minutes}");
            Console.WriteLine($"Seconds: {dif.Seconds}");
        }
    }
}

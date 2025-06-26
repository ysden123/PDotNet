namespace StulSoft.BasicTests.PPatternMatching
{
    /// <summary>
    /// <see cref="Pattern matching overview" href="https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching"/>
    /// </summary>
    internal class PatternMatchingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CommandSwitchTest()
        {
            string res = Choose("Func1");
            Assert.That(res, Is.EqualTo("Func1"));

            res = Choose("Func2");
            Assert.That(res, Is.EqualTo("Func2"));

            Assert.Throws<NotImplementedException>(() => Choose("ttt"));
        }

        private static string Func1()
        {
            return "Func1";
        }

        private static string Func2()
        {
            return "Func2";
        }

        private static string Choose(string input)
        {
            return input switch
            {
                "Func1" => Func1(),
                "Func2" => Func2(),
                _ => throw new NotImplementedException()
            };
        }
    }
}

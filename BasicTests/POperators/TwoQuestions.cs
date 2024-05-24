
namespace StulSoft.BasicTests.POperators
{
    internal class TwoQuestions
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TwoQuestionsTest()
        {
            string? s1 = null;
            Console.WriteLine($"(1) {s1 ?? "default"}");

            s1 = "a value";
            Console.WriteLine($"(2) {s1 ?? "default"}");

            string s2 = null;
            string res;
            res = s2 ?? "default 2";
            Console.WriteLine($"(3) {res}");
            Console.WriteLine($"(3.1) {s2 ?? "default 2"}");

            s2 = "a value 2";
            Console.WriteLine($"(4) {s2 ?? "default 2"}");
        }
    }
}

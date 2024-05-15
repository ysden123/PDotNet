namespace StulSoft.BasicTests.PReferences
{
    internal class SomeValueTests
    {
        internal static void SomeMethod(SomeValue someValueReference)
        {
            someValueReference.Name = $"{someValueReference.Name} modified";
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CtorGetSetTest()
        {
            var sv = new SomeValue(1, "first");
            Console.WriteLine(sv.ToString());
        }

        [Test]
        public void RefTest()
        {
            var sv = new SomeValue(1, "initial name");
            Console.WriteLine(sv.ToString());
            SomeMethod(sv);
            Console.WriteLine(sv.ToString());
        }
    }
}

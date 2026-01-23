namespace StulSoft.BasicTests.PLanguage
{
    internal class FieldBackedPropertyTests
    {
        private int Foo
        {
            get;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                field = value;
            }
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSetTest()
        {
            Foo = 10;
            Assert.That(Foo, Is.EqualTo(10));
            Assert.Throws<ArgumentOutOfRangeException>(() => Foo = -5);
        }
    }
}

namespace ClassTests
{
    public class SavingAccountTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ABankAccount mySavings = new SavingAccount("SA123", 1000m, 2.5m);
            mySavings.Deposit(500m);
            Assert.That(mySavings.Balance, Is.EqualTo(1500m));
            mySavings.DisplayAccountInfo();

            mySavings.Withdraw(200m);
            Assert.That(mySavings.Balance, Is.EqualTo(1300m));
            mySavings.DisplayAccountInfo();
        }
    }
}

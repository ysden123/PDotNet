namespace ClassMSTests;

[TestClass]
public class SavingAccountTests
{
    [TestMethod]
    public void TestMethod1()
    {
        ABankAccount mySavings = new SavingAccount("SA123", 1000m, 2.5m);
        mySavings.Deposit(500m);
        Assert.AreEqual(1500m, mySavings.Balance);
        mySavings.DisplayAccountInfo();

        mySavings.Withdraw(200m);
        Assert.AreEqual(1300m, mySavings.Balance);
        mySavings.DisplayAccountInfo();
    }
}

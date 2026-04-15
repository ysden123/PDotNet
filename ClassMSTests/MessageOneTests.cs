namespace ClassMSTests;

[TestClass]
public class MessageOneTests
{
    [TestMethod]
    public void TestMethod1()
    {
        IMessage messageOne = new MessageOne();
        Assert.AreEqual("MessageOne: This is from GetMessage.", messageOne.GetMessage());
        Assert.AreEqual("This is a default message.", messageOne.DefaultMessage());
    }
}

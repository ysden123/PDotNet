namespace ClassMSTests;

[TestClass]
public class MessageTwoTests
{
    [TestMethod]
    public void TestMethod1()
    {
        IMessage messageTwo = new MessageTwo();
        Assert.AreEqual("MessageTwo: This is from GetMessage.", messageTwo.GetMessage());
        Assert.AreEqual("MessageTwo: This is an overridden default message.", messageTwo.DefaultMessage());
    }
}

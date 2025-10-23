namespace ClassTests;

public class MessageTwoTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        IMessage messageOne = new MessageTwo();
        Assert.Multiple(() =>
        {
            Assert.That(messageOne.GetMessage(), Is.EqualTo("MessageTwo: This is from GetMessage."));
            Assert.That(messageOne.DefaultMessage(), Is.EqualTo("MessageTwo: This is an overridden default message."));
        });
    }
}

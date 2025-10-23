namespace ClassTests;

public class MessageOneTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        IMessage messageOne = new MessageOne();
        Assert.Multiple(() =>
        {
            Assert.That(messageOne.GetMessage(), Is.EqualTo("MessageOne: This is from GetMessage."));
            Assert.That(messageOne.DefaultMessage(), Is.EqualTo("This is a default message."));
        });
    }
}

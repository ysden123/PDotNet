namespace ClassMSTests
{

    internal class MessageOne : IMessage
    {
        public string GetMessage()
        {
            return "MessageOne: This is from GetMessage.";
        }
    }
}
namespace ClassMSTests
{
    internal class MessageTwo: IMessage
    {
        public string GetMessage()
        {
            return "MessageTwo: This is from GetMessage.";
        }

        public string DefaultMessage()
        {
            return "MessageTwo: This is an overridden default message.";
        }
    }
}

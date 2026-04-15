namespace ClassMSTests
{

    internal interface IMessage
    {
        public string GetMessage();
        public string DefaultMessage() { return "This is a default message."; }
    }
}
namespace ClassMSTests
{
    public class BaseClassExtended : BaseClass
    {
        override public string GetInfo()
        {
            return "This is the BaseClassExtended.";
        }

        // Note: This method does not override the base class method because it is not marked as virtual in the base class.
        /*override public string GetMoreInfo()
        {
            return "More info from BaseClassExtended.";
        }*/
    }
}

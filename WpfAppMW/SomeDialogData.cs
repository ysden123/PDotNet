namespace WpfAppMW
{
    public class SomeDialogData
    {
        public string T1 { get; set; }

        public SomeDialogData(string t1)
        {
            T1 = t1;
        }

        public override string? ToString()
        {
            return $"({T1})";
        }
    }
}

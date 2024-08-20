namespace PCrypto
{
    internal static class CtrlSumCalculator
    {
        public static int CalculateCtrlSum(string text)
        {
            return Array.ConvertAll(text.ToCharArray(), c => (int)Char.GetNumericValue(c)).Sum() % 10;
        }
    }
}

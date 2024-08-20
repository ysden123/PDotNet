namespace PCrypto
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("PCrypto started");

            HMACSHA512example.Test();

            Console.WriteLine("Enter digits:");
            string? text = Console.ReadLine();
            if (text != null)
            {
                Console.WriteLine($"Digital text; {text}");
                var cs = CtrlSumCalculator.CalculateCtrlSum(text);
                Console.WriteLine($"Control digit is {cs}");
            }

        }
    }
}
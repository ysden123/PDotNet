namespace TelephoneSwindler
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("Start");
            //var callDays2 = Parser.Parse(@"c:\users\Yuriy\AppData\Roaming\telephone-swindler\telephones.txt");
            //Console.WriteLine("Calls per day:");
            //var totalCount = 0;
            //foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    if (callDays2.TryGetValue(dayOfWeek, out CallsPerDay? callsPerDay))
            //    {
            //        string maxSign = callsPerDay.IsMax? "*" : "";
            //        Console.WriteLine($"{dayOfWeek}: {callsPerDay!.Count} {maxSign}");
            //        totalCount += callsPerDay!.Count;
            //    }
            //}
            //Console.WriteLine($"Total counter={totalCount}");

            NodeFinder.FindNodes(NodeFinder._nodes);
        }
    }
}
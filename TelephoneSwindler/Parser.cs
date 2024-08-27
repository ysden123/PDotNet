using System.Collections.Generic;
using System.Net.Security;

namespace TelephoneSwindler
{
    internal static class Parser
    {
        public static Dictionary<DayOfWeek, CallsPerDay> Parse(string path)
        {
            var callsPerDay = new Dictionary<DayOfWeek, CallsPerDay>();

            foreach (string line in File.ReadAllLines(path))
            {
                var items = line.Split(",");
                var date = DateOnly.ParseExact(items[1].Trim(), "yyyy/MM/dd");
                var theCallsPerDay = callsPerDay.GetValueOrDefault(date.DayOfWeek, new CallsPerDay(date.DayOfWeek, 0, false));
                theCallsPerDay = new CallsPerDay(date.DayOfWeek, theCallsPerDay.Count + 1, false);
                callsPerDay[date.DayOfWeek] = theCallsPerDay;
            }

            var maxCallsPerDay = callsPerDay[0];
            foreach (var call in callsPerDay)
            {
                if (call.Value.Count >= maxCallsPerDay.Count)
                    maxCallsPerDay = call.Value;
            }

            callsPerDay[maxCallsPerDay.DayOfWeek] = new CallsPerDay(maxCallsPerDay.DayOfWeek, maxCallsPerDay.Count, true);

            return callsPerDay;
        }
    }
}

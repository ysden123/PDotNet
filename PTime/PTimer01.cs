using System.Timers;

namespace PTime
{
    internal class PTimer01
    {
        public static void SimpleTimer()
        {
            Console.WriteLine("==>SimpleTimer");
            System.Timers.Timer timer = new(1500); // In 1.5 sec
            timer.Elapsed += (sender, e) =>
            {
                Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            };
            timer.Start();

            Console.WriteLine("Press any key to stop... ");
            Console.ReadKey();
            timer.Stop();
            timer.Dispose();

        }
        public static void TimerWithReset()
        {
            Console.WriteLine("==>TimerWithReset");
            System.Timers.Timer timer = new(1500); // In 1.5 sec
            timer.Elapsed += (sender, e) =>
            {
                Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
                timer.Enabled = false;
            };
            timer.Start();

            Console.WriteLine("Press any key to stop... ");
            Console.ReadKey();
            timer.Stop();
            timer.Dispose();

        }
    }
}

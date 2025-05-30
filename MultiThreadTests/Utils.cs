namespace MultiThreadTests
{
    internal class Utils
    {
        /// <summary>
        /// Outputs the current thread name and a message to the console.
        /// </summary>
        /// <param name="message">A message to write on console</param>
        public static void Trace(string message)
        {
            var t=DateTime.Now.ToString("HH:mm:ff:fff");
            Console.WriteLine($"[{Thread.CurrentThread.Name}, {t}]: {message}");
        }
    }
}

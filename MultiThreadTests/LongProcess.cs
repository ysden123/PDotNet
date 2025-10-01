using YSCommon;

namespace MultiThreadTests
{
    internal class LongProcess
    {
        /// <summary>
        /// It is awaitable method. await can be used to wait till the execution is completed and it will return value of type string.
        /// <br/>
        /// A handler wiil be executed in the same thread where the method is running, not in the caller thread!
        /// </summary>
        /// <param name="handler">A handler will be called at the end of execution.</param>
        /// <returns>Task</returns>
        public static async Task<string> MakeProcess1(Action<string> handler)
        {
            Utils.Trace("==>MakeProcess1");
            var res = await Task.Run(async () =>
            {
                Utils.Trace("Run is started");
                Utils.Trace("Before sleep");
                await Task.Delay(TimeSpan.FromSeconds(10));
                Utils.Trace("After sleep");
                handler("Everything done!");
                return "";
            });
            Utils.Trace("Return res and <==MakeProcess1");
            return res;
        }

        /// <summary>
        /// It is awaitable method. await can be used to wait till the execution is completed but no data is returned.
        /// <br/>
        /// A handler wiil be executed in the same thread where the method is running, not in the caller thread!
        /// </summary>
        /// <param name="handler">A handler will be called at the end of execution.</param>
        /// <returns>Task</returns>
        public static async Task MakeProcess2(Action<string> handler)
        {
            Utils.Trace("==>MakeProcess2");
            var res = await Task.Run(async () =>
            {
                Utils.Trace("Run is started");
                Utils.Trace("Before sleep");
                await Task.Delay(TimeSpan.FromSeconds(10));
                Utils.Trace("After sleep");
                handler("Everything done!");
                return "";
            });
            Utils.Trace("Return and <==MakeProcess2");
        }

        /// <summary>
        /// It is awaitable method. await can be used to wait till the execution is completed and it will return value of type string.
        /// </summary>
        /// <returns>Task</returns>
        public static async Task<string> MakeProcess3()
        {
            Utils.Trace("==>MakeProcess3");
            var res = await Task.Run(async () =>
            {
                Utils.Trace("Run is started");
                Utils.Trace("Before sleep");
                await Task.Delay(TimeSpan.FromSeconds(10));
                Utils.Trace("After sleep");
                return "Everything done! MakeProcess3()";
            });
            Utils.Trace("Return res and <==MakeProcess3");
            return res;
        }
    }
}

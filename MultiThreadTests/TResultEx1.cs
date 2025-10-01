using YSCommon;

namespace MultiThreadTests
{
    internal class TResultEx1
    {
        public static async Task<string> FSuccess()
        {
            Utils.Trace("==>FSuccess");
            var res = await Task.Run(() =>
            {
                Utils.Trace("Running");
                Thread.Sleep(100);
                return Task.FromResult("Done");
            });
            Utils.Trace("Return result");
            return res;
        }

        public static async Task<string> FFail()
        {
            Utils.Trace("==>FFail");
            var res = await Task.Run(() =>
            {
                Utils.Trace("Running");
                Thread.Sleep(100);
                return Task.FromException<string>(new Exception("Test exception"));
            });
            Utils.Trace("Return result");
            return res;
        }

        public static async Task<string> LongProcess(int processTime)
        {
            Utils.Trace($"==>LongProcess({processTime})");
            var res = await Task.Run(() =>
            {
                Utils.Trace("Running");
                Thread.Sleep(processTime);
                return Task.FromResult("Done");
            });
            Utils.Trace("Return result");
            return res;
        }

        public static async Task<string> LongProcessWithException(int processTime, bool toThrowException)
        {
            Utils.Trace($"==>LongProcess({processTime}, {toThrowException})");
            var res = await Task.Run(() =>
            {
                Utils.Trace("Running");
                Thread.Sleep(processTime);
                if (toThrowException)
                    return Task.FromException<string>(new Exception("An internal exception"));
                else
                    return Task.FromResult("Done");
            });
            Utils.Trace("Return result");
            return res;
        }
    }
}

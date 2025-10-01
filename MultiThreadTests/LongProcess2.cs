using YSCommon;

namespace MultiThreadTests
{
    internal class LongProcess2
    {
        public static async Task<LongProcess2Result> MakeJob()
        {
            Utils.Trace("==>MakeJob");
            try
            {
                var r1 = await Task<int>.Run(async () =>
                {
                    Utils.Trace("Before delay");
                    await Task.Delay(1000);
                    Utils.Trace("After delay");
                    return 123;
                });
                return new LongProcess2Result() { Age = r1, Name = $"Name {r1}" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

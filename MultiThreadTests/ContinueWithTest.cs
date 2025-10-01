using YSCommon;

namespace MultiThreadTests;

public class ContinueWithTest
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// The result is consumed by a worker thread of the long process, not by the calling thread.
    /// </summary>
    /// <returns></returns>
    [Test]
    public async Task Test1()
    {
        Utils.Trace("==>Test1");
        await LongProcess.MakeProcess3().ContinueWith(t =>
        {
            Utils.Trace("Test1 in ContinueWith");
            if (t.IsCompletedSuccessfully)
            {
                Utils.Trace("Test1 IsCompletedSuccessfully is true");
                Utils.Trace($"Test1 result is {t.Result}");
            }
            else
            {
                Utils.Trace("Test1 IsCompletedSuccessfully is false");
                Utils.Trace($"Test1 t.IsCanceled is {t.IsCanceled}");
                Utils.Trace($"Test1 t.IsFaulted is {t.IsFaulted}");
            }
        });
        Utils.Trace("<==Test1");
    }

    /// <summary>
    /// The result is consumed in the caller thread.
    /// </summary>
    /// <returns></returns>
    [Test]
    public void Test2()
    {
        Utils.Trace("==>Test2");
        LongProcess.MakeProcess3().ContinueWith(t =>
        {
            Utils.Trace("Test2 in ContinueWith");
            if (t.IsCompletedSuccessfully)
            {
                Utils.Trace("Test2 IsCompletedSuccessfully is true");
                Utils.Trace($"Test2 result is {t.Result}");
            }
            else
            {
                Utils.Trace("Test2 IsCompletedSuccessfully is false");
                Utils.Trace($"Test2 t.IsCanceled is {t.IsCanceled}");
                Utils.Trace($"Test2 t.IsFaulted is {t.IsFaulted}");
            }
        }).Wait();
        Utils.Trace("<==Test2");
    }
}

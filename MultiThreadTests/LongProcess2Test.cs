using YSCommon;

namespace MultiThreadTests;

public class LongProcess2Test
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task MakeJobTest()
    {
        Utils.Trace("==>MakeJobTest");
        var result = await LongProcess2.MakeJob();
        Utils.Trace("We got a result");
        Assert.That(result, Is.Not.Null);
        if (result != null) {
            Utils.Trace($"result is {result}");
        }
    }

    [Test]
    public async Task MakeJobWithTimeoutSucceededTest()
    {
        Utils.Trace("==>MakeJobWithTimeoutSucceededTest");
        try
        {
            var result = await LongProcess2.MakeJob().WaitAsync(TimeSpan.FromMilliseconds(1500));
            Utils.Trace("We got a result");
            Assert.That(result, Is.Not.Null);
            if (result != null)
            {
                Utils.Trace($"result is {result}");
            }
        }
        catch (Exception ex)
        {
            Utils.Trace(ex.Message);
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public async Task MakeJobWithTimeoutFailedTest()
    {
        Utils.Trace("==>MakeJobWithTimeoutFailedTest");
        try
        {
            var result = await LongProcess2.MakeJob().WaitAsync(TimeSpan.FromMilliseconds(500));
            Utils.Trace("We got a result");
            Assert.That(result, Is.Not.Null);
            if (result != null)
            {
                Utils.Trace($"result is {result}");
            }
            Assert.Fail("An exception is expecting");
        }
        catch (Exception ex)
        {
            Utils.Trace(ex.Message);
        }
    }
}

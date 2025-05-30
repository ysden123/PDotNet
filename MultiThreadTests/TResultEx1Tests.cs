namespace MultiThreadTests
{
    internal class TResultEx1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FSuccessTest()
        {
            Utils.Trace("==>FSuccessTest");
            var result = TResultEx1.FSuccess();
            result.Wait();
            Utils.Trace("After result was defined");
            Assert.That(result, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(result.IsFaulted, Is.False);
                Assert.That(result.Result, Is.Not.Null);
            });
            Assert.That(result.Result, Is.EquivalentTo("Done"));
        }

        [Test]
        public void FFailTest()
        {
            Utils.Trace("==>FFailTest");
            try
            {
                var result = TResultEx1.FFail();
                result.Wait();
                Assert.Fail("Exception was expected");
            }
            catch (Exception ex)
            {
                Assert.That(ex.Message, Is.EquivalentTo("One or more errors occurred. (Test exception)"));
            }
        }

        [Test]
        public async Task LongProcessSuccessTest()
        {
            string result;
            try
            {
                result = await TResultEx1
                    .LongProcess(1000)
                    .WaitAsync(TimeSpan.FromMilliseconds(1500));
                Utils.Trace($"Result is {result}");

            }
            catch (TimeoutException ex)
            {
                Utils.Trace($"Timeout exception: {ex.Message}");
                Assert.Fail("No timeout exception is expected.");
            }
            catch (Exception ex)
            {
                Utils.Trace($"Exception: {ex.Message}");
                Assert.Fail("No an exception is expected.");
            }
        }

        [Test]
        public async Task LongProcessFailureTest()
        {
            string result;
            try
            {
                result = await TResultEx1
                    .LongProcess(1500)
                    .WaitAsync(TimeSpan.FromMilliseconds(1000));
                Utils.Trace($"Result is {result}");
                Assert.Fail("The timeout excption is expected.");
            }
            catch (TimeoutException ex)
            {
                Utils.Trace($"Timeout exception: {ex.Message}");
                Assert.Pass(ex.Message);
            }
            catch (Exception)
            {
                Assert.Fail("The timeout exception is expected.");
            }
        }

        [Test]
        public async Task LongProcessWithExceptionTest()
        {
            string result;
            try
            {
                result = await TResultEx1
                    .LongProcessWithException(1000, true)
                    .WaitAsync(TimeSpan.FromMilliseconds(1500));
                Utils.Trace($"Result is {result}");
                Assert.Fail("An internal exception is expected");
            }
            catch (TimeoutException ex)
            {
                Utils.Trace($"Timeout exception: {ex.Message}");
                Assert.Fail("No timeout exception is expected.");
            }
            catch (Exception ex)
            {
                Utils.Trace($"Exception: {ex.Message}");
            }
        }
    }
}

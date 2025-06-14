namespace MultiThreadTests
{
    internal class LongProcessTests
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
        public async Task MakeProcess1Test()
        {
            Utils.Trace("==>MakeProcessTest");
            Utils.Trace("The result is consumed by a worker thread of the long process, not by the calling thread.");
            var res = await LongProcess.MakeProcess1((s) =>
            {
                Utils.Trace("==>handler");
                Utils.Trace($"s is {s}");
            });
            Utils.Trace("<==MakeProcessTest");
        }

        /// <summary>
        /// The result is consumed by a worker thread of the long process, not by the calling thread.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task MakeProcess2Test()
        {
            Utils.Trace("==>MakeProcess2Test");
            Utils.Trace("The result is consumed by a worker thread of the long process, not by the calling thread.");
            await LongProcess.MakeProcess2((s) =>
            {
                Utils.Trace("==>handler");
                Utils.Trace($"s is {s}");
            });
            Utils.Trace("<==MakeProcess2Test");
        }

        /// <summary>
        /// The result is consumed in the caller thread.
        /// </summary>
        /// <returns></returns>
        [Test]
        public void MakeProcess3Test()
        {
            Utils.Trace("==>MakeProcess3Test");
            Utils.Trace("The result is consumed in the caller thread.");
            var res = LongProcess.MakeProcess3();
            Utils.Trace("Before Wait");
            res.Wait();
            Utils.Trace("After Wait");
            Utils.Trace($"res is {res.Result}");
            Utils.Trace("<==MakeProcessTest");
        }

        /// <summary>
        /// The result is consumed by a worker thread of the long process, not by the calling thread.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task MakeProcess3_2Test()
        {
            Utils.Trace("==>MakeProcess3_2Test");
            Utils.Trace("The result is consumed by a worker thread of the long process, not by the calling thread.");
            Utils.Trace("Before await");
            var res = await LongProcess.MakeProcess3();
            Utils.Trace("After await");
            Utils.Trace($"res is {res}");
            Utils.Trace("<==MakeProcess3_2Test");
        }
    }
}

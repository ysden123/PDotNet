namespace PMSTest
{
    [TestClass]
    [DoNotParallelize]
    public sealed class Test1
    {
        private static int counter;

        [ClassInitialize]
        public static void ClassSetup(TestContext context)
        {
            // Class-level initialization code here
            Console.WriteLine("==>ClassSetup()");
            counter = 0;
        }
        
        [ClassCleanup]
        public static void ClassTeardown()
        {
            // Class-level cleanup code here
            Console.WriteLine("==>ClassTeardown()");
            counter = 0;
        }

        [TestInitialize]
        public void TestSetup()
        {
            // Initialization code here
            Console.WriteLine("==>TestSetup()");
            counter++;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Cleanup code here
            Console.WriteLine("==>TestCleanup()");
        }

        [TestMethod]
        public void GetDataTest()
        {
            Console.WriteLine($"counter={counter}");
            var data = Service.GetData();
            Assert.IsNotNull(data);
            Assert.AreEqual("Service Data", data);
        }

        [TestMethod]
        public void GetDataTest2()
        {
            Console.WriteLine($"counter={counter}");
            var data = Service.GetData();
            Assert.IsNotNull(data);
            Assert.AreEqual("Service Data", data);
        }
    }
}

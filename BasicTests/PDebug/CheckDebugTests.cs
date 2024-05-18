
namespace StulSoft.BasicTests.PDebug
{
    internal class CheckDebugTests
    {
        static readonly bool _IsDebug = System.Diagnostics.Debugger.IsAttached;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("==>CheckDebugTests.Test1");
            Console.WriteLine(_IsDebug ? "Is attached." : "Is not attcahed");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("==>CheckDebugTests.Test2");
#if DEBUG
            Console.WriteLine("Debug mode is active");
#else
            Console.WriteLine("Debug mode is not active");
#endif
        }
    }
}

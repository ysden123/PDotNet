
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
    }
}

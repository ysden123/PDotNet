using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.BasicTests.PFormatting
{
    internal class NumberFormatting
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FormatNumber()
        {
            int i = 1;

            string f = $"i={i}";
            Console.WriteLine(f);

            f = $"i={i:D2}";
            Console.WriteLine(f);
        }
    }
}

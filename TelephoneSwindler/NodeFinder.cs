using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneSwindler
{
    internal static class NodeFinder
    {
        public static List<string> _nodes =
        [
            "2345",
            "234",
            "123",
            "12",
            "1234"
        ];

        public static List<string> FindNodes(List<string> nodes)
        {
            Console.WriteLine("==>FindNodes");
            var sortedNodes = new List<string>(nodes);
            sortedNodes.Sort();
            Console.WriteLine("Sorted nodes");
            foreach (var node in sortedNodes)
            {
                Console.WriteLine(node);
            }

            string? lastNode = null;
            foreach (var node in sortedNodes)
            {
                if (lastNode == null)
                {
                    lastNode = node;
                }
                else
                {
                    if (lastNode == node)
                    {
                        // todo ++ node count
                    }
                    else if (node.StartsWith(lastNode))
                    {
                        // todo ???
                    }
                }
            }
            return _nodes;
        }
    }
}

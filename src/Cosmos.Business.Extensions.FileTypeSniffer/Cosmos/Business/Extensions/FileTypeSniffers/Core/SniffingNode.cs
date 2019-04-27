using System.Collections.Generic;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Core
{
    public class SniffingNode
    {
        public SniffingNode(SniffingNode parent, int depth)
        {
            Parent = parent;
            Depth = depth;
        }

        public SniffingNode Parent { get; }

        public SortedList<byte, SniffingNode> Children { get; set; }

        public int Depth { get; }

        public List<string> ExtensionNames { get; set; }
    }
}

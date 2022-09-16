namespace Cosmos.Sniffers.FileTypeSniffers.Core;

/// <summary>
/// Sniffing Node <br />
/// 嗅探节点
/// </summary>
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
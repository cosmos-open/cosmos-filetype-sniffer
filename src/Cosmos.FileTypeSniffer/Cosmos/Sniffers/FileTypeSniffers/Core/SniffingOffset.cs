using System.Text;

namespace Cosmos.Sniffers.FileTypeSniffers.Core;

/// <summary>
/// Sniffing Offset <br />
/// 嗅探偏移量
/// </summary>
public class SniffingOffset
{
    private SniffingOffset() { }

    public int Length { get; private set; }

    public int Start { get; private set; }

    public string Value { get; private set; }

    public static SniffingOffset Create(string[] byteStringArray, int start, int length)
    {
        return new SniffingOffset
        {
            Start = start,
            Length = length,
            Value = Encoding.ASCII.GetString(string.Join(",", byteStringArray, start, length).GetByte())
        };
    }
}
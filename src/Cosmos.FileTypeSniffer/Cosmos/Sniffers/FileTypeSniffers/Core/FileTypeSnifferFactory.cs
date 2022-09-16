using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Core;

/// <summary>
/// FileType Sniffer Factory
/// </summary>
public static class FileTypeSnifferFactory
{
    /// <summary>
    /// Create a new instance of <see cref="FileTypeSniffer"/>. <br />
    /// 创建一个新的 FileTypeSniffer 实例
    /// </summary>
    /// <param name="descriptors"></param>
    /// <param name="separators"></param>
    /// <returns></returns>
    public static FileTypeSniffer Create(List<IFileTypeDescriptor> descriptors, char[] separators = null)
    {
        var sniffer = new FileTypeSniffer();
        foreach (var descriptor in descriptors)
        {
            sniffer.Register(new SniffingMetadata(descriptor, separators));
        }

        return sniffer;
    }
}
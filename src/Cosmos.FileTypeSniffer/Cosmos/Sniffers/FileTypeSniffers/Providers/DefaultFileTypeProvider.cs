using Cosmos.Sniffers.FileTypeSniffers.Core;
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Providers;

/// <summary>
/// Default FileType Provider <br />
/// 默认的文件类型提供者程序
/// </summary>
public class DefaultFileTypeProvider : ISniffingDescriptorProvider
{
    private List<Type> TypesOfFileType { get; }

    public DefaultFileTypeProvider()
    {
        using var scanner = new FileTypeRegistrarScanner();
        TypesOfFileType = scanner.Scan().ToList();
    }

    /// <inheritdoc />
    public IEnumerable<IFileTypeDescriptor> GetDescriptors()
    {
        foreach (var registrarType in TypesOfFileType.ToList())
        {
            if (registrarType is null)
                continue;
            yield return new FileTypeDescriptor(registrarType);
        }
    }
}
using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Core;

/// <summary>
/// Sniffer Descriptor Provider Interface <br />
/// 文件类型嗅探器描述符提供者程序接口
/// </summary>
public interface ISniffingDescriptorProvider
{
    /// <summary>
    /// Get descriptors <br />
    /// 获取描述符
    /// </summary>
    /// <returns></returns>
    IEnumerable<IFileTypeDescriptor> GetDescriptors();
}
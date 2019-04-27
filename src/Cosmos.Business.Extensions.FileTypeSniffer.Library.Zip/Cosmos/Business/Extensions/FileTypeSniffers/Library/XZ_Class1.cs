using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xz,tar.xz")]
    [FileTypeHex("FD 37 7A 58 5A 00 00")]
    public class XZ_Class1 : IFileTypeRegistrar { }
}
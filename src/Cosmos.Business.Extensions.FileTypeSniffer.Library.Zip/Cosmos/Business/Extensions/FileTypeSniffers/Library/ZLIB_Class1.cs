using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("zlib")]
    [FileTypeHex("78 01")]
    public class ZLIB_Class1 : IFileTypeRegistrar { }
}
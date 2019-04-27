using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("lz")]
    [FileTypeHex("4C 5A 49 50")]
    [FileTypeDescription("Lzip Compressed File")]
    public class LZ_Class1 : IFileTypeRegistrar { }
}
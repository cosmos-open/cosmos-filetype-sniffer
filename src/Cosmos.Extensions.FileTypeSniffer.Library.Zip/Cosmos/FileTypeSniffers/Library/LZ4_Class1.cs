using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("lz4")]
    [FileTypeHex("04 22 4D 18")]
    public class LZ4_Class1 : IFileTypeRegistrar { }
}
using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("flac")]
    [FileTypeHex("66 4C 61 43")]
    public class FLAC_Class1 : IFileTypeRegistrar { }
}
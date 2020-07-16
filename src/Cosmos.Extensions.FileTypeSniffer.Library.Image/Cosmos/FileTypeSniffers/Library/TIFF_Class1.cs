using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("49 49 2A 00")]
    public class TIFF_Class1 : IFileTypeRegistrar { }
}
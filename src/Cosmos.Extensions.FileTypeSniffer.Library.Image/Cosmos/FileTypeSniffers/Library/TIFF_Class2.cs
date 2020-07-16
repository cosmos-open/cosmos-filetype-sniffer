using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("4D 4D 00 2A")]
    public class TIFF_Class2 : IFileTypeRegistrar { }
}
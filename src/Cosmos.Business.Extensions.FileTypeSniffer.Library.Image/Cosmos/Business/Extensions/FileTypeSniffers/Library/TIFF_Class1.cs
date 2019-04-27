using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("49 49 2A 00")]
    public class TIFF_Class1 : IFileTypeRegistrar { }
}
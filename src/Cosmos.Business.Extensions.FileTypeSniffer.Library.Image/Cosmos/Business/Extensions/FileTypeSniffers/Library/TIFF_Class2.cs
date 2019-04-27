using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tif,tiff")]
    [FileTypeHex("4D 4D 00 2A")]
    public class TIFF_Class2 : IFileTypeRegistrar { }
}
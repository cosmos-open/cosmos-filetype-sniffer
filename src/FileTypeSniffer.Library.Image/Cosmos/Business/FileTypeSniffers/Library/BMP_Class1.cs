using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bmp")]
    [FileTypeHex("42 4D")]
    public class BMP_Class1 : IFileTypeRegistrar { }
}
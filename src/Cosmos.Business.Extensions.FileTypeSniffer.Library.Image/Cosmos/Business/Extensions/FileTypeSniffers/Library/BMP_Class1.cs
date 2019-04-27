using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bmp")]
    [FileTypeHex("42 4D")]
    public class BMP_Class1 : IFileTypeRegistrar { }
}
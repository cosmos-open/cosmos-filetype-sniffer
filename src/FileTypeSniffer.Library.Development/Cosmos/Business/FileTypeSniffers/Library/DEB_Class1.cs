using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("deb")]
    [FileTypeHex("21 3C 61 72 63 68 3E")]
    public class DEB_Class1 : IFileTypeRegistrar { }
}
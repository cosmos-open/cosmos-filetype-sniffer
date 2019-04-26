using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,03,04")]
    [FileTypeDescription("OpenDocument Text")]
    public class ODT_Class1 : IFileTypeRegistrar { }
}
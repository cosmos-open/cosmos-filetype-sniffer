using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,05,06")]
    [FileTypeDescription("OpenDocument Text")]
    public class ODT_Class3 : IFileTypeRegistrar { }
}
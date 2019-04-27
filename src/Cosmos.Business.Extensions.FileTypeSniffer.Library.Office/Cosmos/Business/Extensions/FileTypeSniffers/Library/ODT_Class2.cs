using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("odt")]
    [FileTypeHex("50,4b,07,08")]
    [FileTypeDescription("OpenDocument Text")]
    public class ODT_Class2 : IFileTypeRegistrar { }
}
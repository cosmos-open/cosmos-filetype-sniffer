using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("webm")]
    [FileTypeHex("1A 45 DF A3")]
    public class WebM_Class1 : IFileTypeRegistrar { }
}
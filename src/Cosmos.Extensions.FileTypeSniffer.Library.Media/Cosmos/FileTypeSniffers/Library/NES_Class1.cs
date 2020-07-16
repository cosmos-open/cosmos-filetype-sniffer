using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("nes")]
    [FileTypeHex("4E 45 53 1A")]
    public class NES_Class1 : IFileTypeRegistrar { }
}
using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("nes")]
    [FileTypeHex("4E 45 53 1A")]
    public class NES_Class1 : IFileTypeRegistrar { }
}
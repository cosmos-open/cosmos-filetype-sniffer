using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("psd")]
    [FileTypeHex("38 42 50 53")]
    public class PSD_Class1 : IFileTypeRegistrar { }
}
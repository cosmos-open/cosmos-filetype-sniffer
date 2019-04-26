using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bin")]
    [FileTypeHex("53 50 30 31")]
    public class BIN_Class1 : IFileTypeRegistrar { }
}

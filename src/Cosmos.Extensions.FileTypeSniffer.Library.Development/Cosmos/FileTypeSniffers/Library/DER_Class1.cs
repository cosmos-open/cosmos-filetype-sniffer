using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("der")]
    [FileTypeHex("30 82")]
    public class DER_Class1 : IFileTypeRegistrar { }
}
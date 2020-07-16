using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("iso")]
    [FileTypeHex("43 44 30 30 31")]
    [FileTypeOffset(36865)]
    public class ISO_Class3 : IFileTypeRegistrar { }
}
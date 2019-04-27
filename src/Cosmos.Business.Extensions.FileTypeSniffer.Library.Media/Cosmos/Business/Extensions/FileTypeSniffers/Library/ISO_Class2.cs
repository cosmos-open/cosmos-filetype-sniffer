using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("iso")]
    [FileTypeHex("43 44 30 30 31")]
    [FileTypeOffset(34817)]
    public class ISO_Class2 : IFileTypeRegistrar { }
}
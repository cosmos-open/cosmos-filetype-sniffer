using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("iso")]
    [FileTypeHex("43 44 30 30 31")]
    [FileTypeOffset(32769)]
    public class ISO_Class1 : IFileTypeRegistrar { }
}
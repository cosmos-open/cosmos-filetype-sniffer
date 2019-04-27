using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("der")]
    [FileTypeHex("30 82")]
    public class DER_Class1 : IFileTypeRegistrar { }
}
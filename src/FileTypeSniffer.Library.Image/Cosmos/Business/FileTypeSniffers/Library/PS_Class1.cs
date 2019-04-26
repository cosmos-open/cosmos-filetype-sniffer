using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ps")]
    [FileTypeHex("25 21 50 53")]
    public class PS_Class1 : IFileTypeRegistrar { }
}
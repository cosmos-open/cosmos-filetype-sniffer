using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cwk")]
    [FileTypeHex("05 07 00 00 42 4F 42 4F 05 07 00 00 00 00 00 00 00 00 00 00 00 01")]
    public class CWK_Class1 : IFileTypeRegistrar { }
}
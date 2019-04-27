using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cwk")]
    [FileTypeHex("06 07 E1 00 42 4F 42 4F 06 07 E1 00 00 00 00 00 00 00 00 00 00 01")]
    public class CWK_Class2 : IFileTypeRegistrar { }
}
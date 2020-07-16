using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cab")]
    [FileTypeHex("4D 53 43 46")]
    public class CAB_Class1 : IFileTypeRegistrar { }
}
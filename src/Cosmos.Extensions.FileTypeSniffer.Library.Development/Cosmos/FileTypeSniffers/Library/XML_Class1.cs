using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xml")]
    [FileTypeHex("3c 3f 78 6d 6c 20")]
    public class XML_Class1 : IFileTypeRegistrar { }
}
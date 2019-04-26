using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xml")]
    [FileTypeHex("3c 3f 78 6d 6c 20")]
    public class XML_Class1 : IFileTypeRegistrar { }
}
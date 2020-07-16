using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("orc")]
    [FileTypeHex("4F 52 43")]
    public class ORC_Class1 : IFileTypeRegistrar { }
}
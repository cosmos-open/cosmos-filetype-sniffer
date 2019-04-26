using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("orc")]
    [FileTypeHex("4F 52 43")]
    public class ORC_Class1 : IFileTypeRegistrar { }
}
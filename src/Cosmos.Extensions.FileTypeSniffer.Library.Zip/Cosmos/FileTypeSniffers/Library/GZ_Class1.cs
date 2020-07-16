using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("gz,tar.gz")]
    [FileTypeHex("1F 8B")]
    public class GZ_Class1 : IFileTypeRegistrar { }
}
using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("z,tar.z")]
    [FileTypeHex("1F 9D")]
    public class Z_Class1 : IFileTypeRegistrar { }
}
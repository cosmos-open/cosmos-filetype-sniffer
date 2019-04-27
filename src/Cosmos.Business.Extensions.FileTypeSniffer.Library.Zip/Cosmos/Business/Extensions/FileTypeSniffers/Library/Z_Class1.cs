using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("z,tar.z")]
    [FileTypeHex("1F 9D")]
    public class Z_Class1 : IFileTypeRegistrar { }
}
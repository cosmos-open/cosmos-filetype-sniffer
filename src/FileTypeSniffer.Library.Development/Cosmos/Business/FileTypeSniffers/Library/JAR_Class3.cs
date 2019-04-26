using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jar")]
    [FileTypeHex("50,4b,05,06")]
    public class JAR_Class3 : IFileTypeRegistrar { }
}
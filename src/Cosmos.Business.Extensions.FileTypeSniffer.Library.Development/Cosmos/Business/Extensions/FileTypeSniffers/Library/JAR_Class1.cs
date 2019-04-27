using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jar")]
    [FileTypeHex("50,4b,03,04")]
    public class JAR_Class1 : IFileTypeRegistrar { }
}
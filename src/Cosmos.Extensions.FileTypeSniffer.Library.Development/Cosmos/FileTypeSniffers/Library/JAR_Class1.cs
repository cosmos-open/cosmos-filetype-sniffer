using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("jar")]
    [FileTypeHex("50,4b,03,04")]
    public class JAR_Class1 : IFileTypeRegistrar { }
}
using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,03,04")]
    public class APK_Class1 : IFileTypeRegistrar { }
}
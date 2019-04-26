using Cosmos.Business.FileTypeSniffers.Registering;

namespace Cosmos.Business.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,03,04")]
    public class APK_Class1 : IFileTypeRegistrar { }
}
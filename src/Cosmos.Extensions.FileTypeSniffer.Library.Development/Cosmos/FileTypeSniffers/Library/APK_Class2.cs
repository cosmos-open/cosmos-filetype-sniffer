using Cosmos.FileTypeSniffers.Registering;

namespace Cosmos.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,07,08")]
    public class APK_Class2 : IFileTypeRegistrar { }
}
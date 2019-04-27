using Cosmos.Business.Extensions.FileTypeSniffers.Registering;

namespace Cosmos.Business.Extensions.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("apk")]
    [FileTypeHex("50,4b,05,06")]
    public class APK_Class3 : IFileTypeRegistrar { }
}
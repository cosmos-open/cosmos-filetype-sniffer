using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("exr")]
    [FileTypeHex("76 2F 31 01")]
    [FileTypeDescription("OpenEXR，开放标准的高动态范围图像格式")]
    public class _Exr_Fingerprint : IFileTypeFingerprint { }
}
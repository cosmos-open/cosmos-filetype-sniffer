using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("cr2")]
    [FileTypeHex("49 49 2A 00 10 00 00 00 43 52")]
    [FileTypeDescription("佳能 Canon 单反相机格式化")]
    public class _Cr2_Fingerprint : IFileTypeFingerprint { }
}
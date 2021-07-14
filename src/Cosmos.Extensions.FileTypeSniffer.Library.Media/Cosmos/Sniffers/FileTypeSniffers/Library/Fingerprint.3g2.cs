using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("3g2")]
    [FileTypeHex("66 74 79 70 33 67")]
    [FileTypeOffset(4)]
    public class _3g2_Fingerprint : IFileTypeFingerprint { }
}
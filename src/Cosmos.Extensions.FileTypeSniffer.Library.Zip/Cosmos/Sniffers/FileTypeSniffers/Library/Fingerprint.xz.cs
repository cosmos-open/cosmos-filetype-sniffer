using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("xz,tar.xz")]
    [FileTypeHex("FD 37 7A 58 5A 00 00")]
    public class _Xz_Fingerprint : IFileTypeFingerprint { }
}
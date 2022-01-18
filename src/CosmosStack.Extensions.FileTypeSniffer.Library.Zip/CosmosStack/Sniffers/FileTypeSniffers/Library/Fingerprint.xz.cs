using CosmosStack.Sniffers.FileTypeSniffers.Registering;

// ReSharper disable InconsistentNaming

namespace CosmosStack.Sniffers.FileTypeSniffers.Library
{
    [FileTypeExtensionNames("xz,tar.xz")]
    [FileTypeHex("FD 37 7A 58 5A 00 00")]
    public class _Xz_Fingerprint : IFileTypeFingerprint { }
}
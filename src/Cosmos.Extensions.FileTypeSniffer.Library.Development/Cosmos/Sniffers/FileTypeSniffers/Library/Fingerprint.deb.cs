using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("deb")]
    [FileTypeHex("21 3C 61 72 63 68 3E")]
    public class _Deb_Fingerprint : IFileTypeFingerprint { }
}
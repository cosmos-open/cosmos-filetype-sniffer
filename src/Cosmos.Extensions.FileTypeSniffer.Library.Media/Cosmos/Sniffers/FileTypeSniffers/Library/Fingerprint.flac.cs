using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("flac")]
    [FileTypeHex("66 4C 61 43")]
    public class _Flac_Fingerprint : IFileTypeFingerprint { }
}
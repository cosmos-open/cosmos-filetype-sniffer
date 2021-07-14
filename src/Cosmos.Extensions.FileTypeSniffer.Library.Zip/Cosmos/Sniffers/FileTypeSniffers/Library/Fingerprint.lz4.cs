using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("lz4")]
    [FileTypeHex("04 22 4D 18")]
    public class _Lz4_Fingerprint : IFileTypeFingerprint { }
}
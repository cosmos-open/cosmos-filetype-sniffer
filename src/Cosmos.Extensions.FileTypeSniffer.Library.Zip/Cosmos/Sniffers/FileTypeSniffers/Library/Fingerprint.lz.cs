using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("lz")]
    [FileTypeHex("4C 5A 49 50")]
    [FileTypeDescription("Lzip Compressed File")]
    public class _Lz_Fingerprint : IFileTypeFingerprint { }
}
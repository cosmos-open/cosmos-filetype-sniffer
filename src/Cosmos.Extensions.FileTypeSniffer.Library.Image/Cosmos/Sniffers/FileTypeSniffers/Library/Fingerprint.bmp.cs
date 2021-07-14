using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("bmp")]
    [FileTypeHex("42 4D")]
    public class _Bmp_Fingerprint : IFileTypeFingerprint { }
}
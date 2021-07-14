using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("orc")]
    [FileTypeHex("4F 52 43")]
    public class _Orc_Fingerprint : IFileTypeFingerprint { }
}
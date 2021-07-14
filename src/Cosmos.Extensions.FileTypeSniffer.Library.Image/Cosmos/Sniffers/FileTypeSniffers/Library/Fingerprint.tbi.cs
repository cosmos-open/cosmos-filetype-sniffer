using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("tbi")]
    [FileTypeHex("00 00 00 00 14 00 00 00")]
    public class _Tbi_Fingerprint : IFileTypeFingerprint { }
}
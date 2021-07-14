using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ttf")]
    [FileTypeHex("00 01 00 00 00")]
    public class _Ttf_Fingerprint : IFileTypeFingerprint { }
}
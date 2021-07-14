using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("crx")]
    [FileTypeHex("43 72 32 34")]
    [FileTypeDescription("Google Chrome extensions file")]
    public class _Crx_Fingerprint : IFileTypeFingerprint { }
}
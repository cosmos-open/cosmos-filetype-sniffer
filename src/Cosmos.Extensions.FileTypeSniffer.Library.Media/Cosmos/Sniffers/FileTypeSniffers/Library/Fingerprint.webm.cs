using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("webm")]
    [FileTypeHex("1A 45 DF A3")]
    public class _WebM_Fingerprint : IFileTypeFingerprint { }
}
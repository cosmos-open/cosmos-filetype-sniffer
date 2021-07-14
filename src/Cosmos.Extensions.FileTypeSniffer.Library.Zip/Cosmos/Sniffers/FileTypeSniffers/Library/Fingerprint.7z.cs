using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("7z")]
    [FileTypeHex("37 7A BC AF 27 1C")]
    public class _7z_Fingerprint : IFileTypeFingerprint { }
}
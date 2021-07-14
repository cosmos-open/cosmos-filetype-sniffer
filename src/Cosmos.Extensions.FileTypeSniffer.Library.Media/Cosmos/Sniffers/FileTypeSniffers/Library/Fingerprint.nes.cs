using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("nes")]
    [FileTypeHex("4E 45 53 1A")]
    public class _Nes_Fingerprint : IFileTypeFingerprint { }
}
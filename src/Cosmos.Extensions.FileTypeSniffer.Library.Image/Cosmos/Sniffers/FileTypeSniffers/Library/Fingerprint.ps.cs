using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("ps")]
    [FileTypeHex("25 21 50 53")]
    public class _Ps_Fingerprint : IFileTypeFingerprint { }
}
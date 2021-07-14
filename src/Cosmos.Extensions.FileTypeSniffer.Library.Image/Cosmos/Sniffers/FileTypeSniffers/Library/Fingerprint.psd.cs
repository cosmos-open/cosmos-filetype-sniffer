using Cosmos.Sniffers.FileTypeSniffers.Registering;

namespace Cosmos.Sniffers.FileTypeSniffers.Library
{
    // ReSharper disable once InconsistentNaming
    [FileTypeExtensionNames("psd")]
    [FileTypeHex("38 42 50 53")]
    public class _Psd_Fingerprint : IFileTypeFingerprint { }
}